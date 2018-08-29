using Production.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production.ProductionTest
{
    class TestFlow:ITestFlow
    {
        private AllForms.FormMain frmMain;

        private string planCode;
        private string eid;
        private int result;
        private string procedure;
        private string station;
        private string log;

        public string PlanCode
        {
            get
            {
                return planCode;
            }

            set
            {
                planCode = value;
            }
        }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="frmMain"></param>
        /// <param name="planCode"></param>
        /// <param name="procedure"></param>
        /// <param name="station"></param>
        public TestFlow(AllForms.FormMain frmMain, string eid,string log,int result,string planCode)
        {
            this.frmMain = frmMain;
            this.eid = eid;
            this.log = log;
            this.result = result;
            this.planCode = planCode;
            procedure = ProductionInfo.Procedure;
            station = ProductionInfo.Station;
        }


        /// <summary>
        /// 任务流
        /// </summary>
        /// <returns></returns>
        public int TestTaskFlow()
        {
            int ret = -1;


            frmMain.DisplayLog("测试数据上报服务器\r\n");
            //EID上报服务器
            int resultUpload = result == 0 ? 1 : 2;
            //string testDada = string.Empty;
            //string log = frmMain.ReadLog();

            ret = EidUpload(resultUpload, log);
            if (ret != 0)
            {
                frmMain.DisplayLog("过站失败\r\n");
                return ret;
            }

            ret = 0;
            return ret;
        }



        /// <summary>
        /// EID上报
        /// </summary>
        /// <returns></returns>
        private int EidUpload(int result, string log)
        {
            int ret = -1;

            HttpEidUpload httpEidUpload = new HttpEidUpload();
            try
            {
                ret = httpEidUpload.DataGetAndAnalysis(eid,procedure, planCode, station, result, "", log);
                if (ret != 0)
                {
                    //frmMain.DisplayLog(((ReturnCode)httpEidImeiSnUpload.Response.code).ToString());
                    frmMain.DisplayLog(httpEidUpload.Response.message + "\r\n");
                    frmMain.DisplayLog(httpEidUpload.Response.data.message + "\r\n");
                }
                else
                {
                    frmMain.DisplayLog(string.Format("{0}\r\n", "EID上报服务器成功"));
                    ret = 0;
                }
            }
            catch (Exception ex)
            {
                frmMain.DisplayLog(ex.ToString() + "\r\n");
            }

            return ret;
        }

    }
}
