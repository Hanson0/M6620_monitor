using Production.AllForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Production
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
           //testc ( );
            //运行环境检查
            FactoryAuto.CommonFunction.CheckSystemDrive();
            ConfigInfo.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;
            Application.Run(new FormMain());
        }


        /// <summary>
        /// 应用程序关闭前触发事件
        /// 执行程序的善后操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ApplicationExit(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 系统小模块测试代码
        /// </summary>
        private static void  testc()
        {

        }

    }
}
