using Production.AllForms;
using Production.ProductionTest;
using Production.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Production.Result
{
    //结果判定类
    class ResultJudge
    {
        private AllForms.FormMain frmMain;
        private static object obj = new object();


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="frmMain"></param>
        public ResultJudge(AllForms.FormMain frmMain)
        {
            this.frmMain = frmMain;
        }


        /// <summary>
        /// 测试线程 输出结果
        /// </summary>
        /// <param name="un"></param>
        /// <param name="result"></param>
        public void PutResult(int result)
        {
            StringBuilder log = new StringBuilder();

            if (result == 0)
            {
                log.Append("\r\n");
                log.Append("########     ###     ######   ######\r\n");
                log.Append("##     ##   ## ##   ##    ## ##    ##\r\n");
                log.Append("##     ##  ##   ##  ##       ##\r\n");
                log.Append("########  ##     ##  ######   ######\r\n");
                log.Append("##        #########       ##       ##\r\n");
                log.Append("##        ##     ## ##    ## ##    ##\r\n");
                log.Append("##        ##     ##  ######   ######\r\n");

                frmMain.SetTextBoxColor(EnumControlWidget.txtLog.ToString(),
                    Color.Green);

                lock (obj)
                {
                    frmMain.DisplayResultStatistics(ResultInfo.Pass = ResultInfo.Pass + 1, ResultInfo.Fail);
                }
            }
            else
            {
                log.Append("\r\n");
                log.Append("########    ###     ####  ##\r\n");
                log.Append("##         ## ##     ##   ##\r\n");
                log.Append("##        ##   ##    ##   ##\r\n");
                log.Append("######   ##     ##   ##   ##\r\n");
                log.Append("##       #########   ##   ##\r\n");
                log.Append("##       ##     ##   ##   ##\r\n");
                log.Append("##       ##     ##  ####  ########\r\n");

                frmMain.SetTextBoxColor(EnumControlWidget.txtLog.ToString(),
                    Color.Red);

                lock (obj)
                {
                    frmMain.DisplayResultStatistics(ResultInfo.Pass, ResultInfo.Fail = ResultInfo.Fail + 1);
                }
            }

            frmMain.DisplayLog(log.ToString());
        }
    }
}