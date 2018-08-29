using Production.AllForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Production.Log
{
    class LogHelper
    {
        private FormMain frmMain;

        public LogHelper(FormMain frmMain)
        {
            this.frmMain = frmMain;
        }



        /// <summary>
        /// 生成log文件
        /// </summary>
        /// <param name="un"></param>
        /// <param name="result"></param>
        public void WriteLog(string un, int result)
        {
            string logFileName = null;

            if (string.IsNullOrEmpty(un))
            {
                MessageBox.Show("唯一号为空，LOG文件生成异常");
                return ;
            }

            if (result == 0)
            {
                logFileName = string.Format("{0}{1}_{2}_PASS.LOG", Log.LogInfo.FolderLog, un.ToUpper(),
                    DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            }
            else
            {
                logFileName = string.Format("{0}{1}_{2}_FAIL.LOG", Log.LogInfo.FolderLog, un.ToUpper(),
                    DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            }

            //读取UI控件文本信息
            string log = frmMain.ReadLog();

            //将文本写入文件流，生成文件
            using (FileStream fs = new FileStream(logFileName, FileMode.OpenOrCreate))
            {
                byte[] byteWrite = Encoding.UTF8.GetBytes(log);
                fs.Write(byteWrite, 0, byteWrite.Length);
            }
        }
    }
}
