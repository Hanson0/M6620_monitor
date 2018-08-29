using Production.ProductionTest;
using Production.Server;
using Production.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Production.FolderMonitor
{
    class FolderMonitorHelper
    {
        private FileSystemWatcher watcher;
        private string fileOnCreatedFullName;
        private string fileOnCreatedName;
        private string eid;
        private AllForms.FormMain frmMain;

        private static string configPath = ConfigInfo.ConfigPath;            //配置文件路径
        private static string configOfMesPath = ConfigInfo.ConfigOfMesPath;  //配置imei文件路径
        private static int testFunc;
        private static string baseurl;
        public static int TestFunc
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                Win32API.GetPrivateProfileString("Function", "TestFunction", "", stringBuilder, 256, configPath);
                try
                {
                    testFunc = int.Parse(stringBuilder.ToString());
                }
                catch (Exception)
                {
                    testFunc = 0;
                    return testFunc;
                }
                return testFunc;
            }
        }

        public static string Baseurl
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                Win32API.GetPrivateProfileString("Server", "baseurl", "", stringBuilder, 256, configOfMesPath);
                baseurl = stringBuilder.ToString();
                return baseurl;
            }
        }



        public FolderMonitorHelper(AllForms.FormMain frmMain)
        {
            this.frmMain = frmMain;
            watcher = new FileSystemWatcher(FolderMonitorInfo.MonitorFolderPath);
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true; //启用FileSystemWatcher
            watcher.Created += Watcher_Created;
            //watcher.Changed += watcher_Changed;
            //watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            //watcher.Renamed += new RenamedEventHandler(OnRenamed);
        }


        string tempName="";
        void watcher_Changed ( object sender , FileSystemEventArgs e )
        {
            if ( e.FullPath != tempName ) return;
            tempName = "";

        
        }


        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            
           // tempName = e.FullPath;

            //Console.WriteLine("文件新建事件处理逻辑 {0}  {1}  {2}", e.ChangeType, e.FullPath, e.Name);
            fileOnCreatedFullName = e.FullPath;
            fileOnCreatedName = fileOnCreatedFullName.Substring ( fileOnCreatedFullName.LastIndexOf ( "\\" ) + 1 );

            string patternRF = @"[\dA-F]{20}__\d{4}_\d{2}_\d{2}_\d{2}_\d{2}_\d{2}_";
            string patternPass = @"[\dA-F]{20}__\d{4}_\d{2}_\d{2}_\d{2}_\d{2}_\d{2}_.log";

            //string patternOfGPS = @"^\d{20}_\d{8}_\d{6}_(PASS|FAIL).(LOG|log|Log)$";

            //01_IMEI-ICCID-IMSI-EID-SN_年月日_时分秒_pass.log
            //01_865439030000610-898602C99916C0366442-123456789012345-898602C99916C0366442-CH04037470010061_20180809_175339_FAIL
            //新的log匹配
            string patternOfGPS=@"(01_)(\d*)-([0-9a-zA-Z]*)-([0-9a-zA-Z]*)-([0-9a-zA-Z]*)-([0-9a-zA-Z]*)(_\d{8}_\d{6}_)(PASS|FAIL)(\.log)$";

            int result = -1;
            //匹配RF性能测试
            if (TestFunc==0)
            {
                if (Regex.IsMatch(fileOnCreatedName, patternRF))
                {

                    frmMain.ClearUILastTestState();
                    #region MyRegion
                    //if (Regex.IsMatch(fileOnCreatedName, patternPass))
                    //{
                    //    frmMain.DisplayLog(string.Format("已获取文件名：{0}\r\n", fileOnCreatedName));
                    //    frmMain.DisplayLog("性能测试合格\r\n");
                    //    result = 0;
                    //}
                    //else
                    //{
                    //    frmMain.DisplayLog(string.Format("已获取文件名：{0}\r\n", fileOnCreatedName));
                    //    string patternFail = @"(?<=^[\dA-F]{20}__\d{4}_\d{2}_\d{2}_\d{2}_\d{2}_\d{2}_)(.*)(?=\.log$)";
                    //    string failStr = Regex.Match(fileOnCreatedName, patternFail).Value;
                    //    frmMain.DisplayLog(string.Format("性能测试不合格：{0}\r\n", failStr));
                    //    result = -1;
                    //}
                    #endregion
                    var retmatch = Regex.Match(fileOnCreatedName, patternRF, RegexOptions.IgnoreCase);
                    if (retmatch.Success)
                    {
                        string t = retmatch.Groups[8].Value;
                        eid = retmatch.Groups[5].Value;
                        //frmMain.DisplayLog(string);

                        //绑定IMEI
                        //若IMES返回:已绑定，ret应该为0,仍然进行性能测试
                        int ret = EidBindImei();
                        if (ret != 0)
                        {
                            //显示结果：绑定失败,并改变颜色
                            result = -1;
                            return;
                        }
                        //调用打印接口下拉eid相关信息rep，为了生成Log作准备
                        Production.Server.NewHttpImeiPrint.ResponseInfo rep;
                        ret = ImeiPrint(out rep);
                        if (ret!=0)
                        {
                            //显示结果：下拉失败,并改变颜色
                            result = -1;
                            return;
                        }

                        if (t.ToUpper().Contains("PASS"))
                        {
                            frmMain.DisplayLog("性能测试合格\r\n");
                            result = 0;
                            //Baseurl
                        }
                        else
                        {
                            frmMain.DisplayLog(string.Format("性能测试不合格：{0}\r\n", eid));
                            result = -1;
                        }
                        //System.Windows.Forms.MessageBox.Show ( "find！！！");
                        Thread.Sleep(3000);  //3s后再处理
                    }

                }
                else
                {
                    return;
                }


            }
            //GPS测试
            if (TestFunc == 1)
            {
                #region 对应新log日志格式 //20180810 majianbo
                if (Regex.IsMatch(fileOnCreatedName, patternOfGPS, RegexOptions.IgnoreCase))  //找到日志
                {

                    frmMain.ClearUILastTestState();
                    var retmatch = Regex.Match(fileOnCreatedName, patternOfGPS, RegexOptions.IgnoreCase);
                    if (retmatch.Success)
                    {
                        string t = retmatch.Groups[8].Value;
                        eid = retmatch.Groups[5].Value;
                        if (t.ToUpper().Contains("PASS"))
                        {
                            frmMain.DisplayLog("GPS测试合格\r\n");
                            result = 0;
                        }
                        else
                        {
                            frmMain.DisplayLog("GPS测试不合格\r\n");
                            result = -1;
                        }
                        //System.Windows.Forms.MessageBox.Show ( "find！！！");
                        Thread.Sleep(3000);  //3s后再处理
                    }
                }
                else
                {
                    return;
                }

                #endregion
            }
            //  eid = fileOnCreatedName.Substring(0, 20);        //保存性能测试产生log文件中的eid
            frmMain.SetText ( AllForms.EnumControlWidget.txtEid.ToString ( ) , eid , false );
            frmMain.DisplayLog ( string.Format ( "已获取EID：{0}\r\n" , eid ) );
            
           // frmMain.Update ( );

            bool isUse = false;
            int cnt=0;
            do
            {
                isUse = CheckFileIsUsing ( fileOnCreatedFullName );
                Thread.Sleep ( 10 );
                //if ( cnt++ > 600 )  //大于10s
                //{
                //    //System.Windows.Forms.MessageBox.Show ( "find！！！" );
                //    result = -1;
                //    break;
                //}
            } while ( isUse );

            string log ="";
            //if ( isUse == false )
            //{
                //读取LOG
            try
            {
                log = ReadInfoFromLog ( );
            }
            catch ( Exception ex )
            {
                System.Windows.Forms.MessageBox.Show (ex.Message );
            }
               
           // }
            //设定流程
            TestFlow flow = new TestFlow ( frmMain , eid , log , result , ProductionInfo.PlanCode );

            //加载流程
            ViewControlers view = new ViewControlers ( frmMain , flow , eid );
            //开启线程
            Thread thread = new Thread ( view.StartTest );
            thread.IsBackground = true;
            thread.Start ( );
        }
        /// <summary>
        /// imei绑定
        /// </summary>
        /// <param name="result"></param>
        /// <param name="log"></param>
        /// <returns></returns>
        private int EidBindImei()//int result, string log
        {
            int ret = -1;

            NewHttpEidBindImei httpEidUpload = new NewHttpEidBindImei();
            try
            {
                ret = httpEidUpload.DataGetAndAnalysis(null,null,null,eid,null);
                if (ret != 0)
                {
                    //frmMain.DisplayLog(((ReturnCode)httpEidImeiSnUpload.Response.code).ToString());
                    frmMain.DisplayLog("绑定失败\r\n");
                    //frmMain.DisplayLog(httpEidUpload.Response.data.message + "\r\n");
                }
                else
                {
                    frmMain.DisplayLog(string.Format("{0}\r\n", "绑定成功"));
                    ret = 0;
                }
            }
            catch (Exception ex)
            {
                frmMain.DisplayLog(ex.ToString() + "\r\n");
            }

            return ret;
        }

        /// <summary>
        /// imei信息下拉
        /// </summary>
        /// <param name="result"></param>
        /// <param name="log"></param>
        /// <returns></returns>
        private int ImeiPrint(out Production.Server.NewHttpImeiPrint.ResponseInfo rep)//int result, string log
        {
            int ret = -1;
            rep = null;
            NewHttpImeiPrint httpImeiPrint = new NewHttpImeiPrint();
            //Production.Server.NewHttpImeiPrint.ResponseInfo response;
            try
            {
                ret = httpImeiPrint.DataGetAndAnalysis(out rep, null, null, null, eid, null);
                if (ret != 0)
                {
                    //frmMain.DisplayLog(((ReturnCode)httpEidImeiSnUpload.Response.code).ToString());
                    frmMain.DisplayLog("下拉信息失败\r\n");
                    //frmMain.DisplayLog(httpEidUpload.Response.data.message + "\r\n");
                }
                else
                {
                    frmMain.DisplayLog(string.Format("{0}\r\n", "下拉成功"));
                    ret = 0;
                }
            }
            catch (Exception ex)
            {
                frmMain.DisplayLog(ex.ToString() + "\r\n");
            }

            return ret;
        }


        /// <summary>
        /// 检测文件是否被占用
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private bool CheckFileIsUsing(string file)
        {
            bool inUse = true;

            FileStream fs = null;
            try
            {          
                fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.None);          
                inUse = false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (fs != null)          
                    fs.Close();
            }
            return inUse;//true表示正在使用,false没有使用           
    }


        /// <summary>
        /// 读取LOG
        /// </summary>
        /// <returns></returns>
        private string ReadInfoFromLog()
        {
            string log;

            using (FileStream fs = File.OpenRead(fileOnCreatedFullName))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    log  = sr.ReadToEnd();
                }
            }            
            return log;
        }
    }
}
