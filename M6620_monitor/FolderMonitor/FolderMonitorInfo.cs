using Production.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Production.FolderMonitor
{
    class FolderMonitorInfo
    {
        private static string monitorFolderPath;        //性能测试软件LOG目录


        public static string MonitorFolderPath
        {
            get
            {
                return monitorFolderPath;
            }

            set
            {
                monitorFolderPath = value;
            }
        }




        public static void ReadConfig()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string fileConfig = ConfigInfo.ConfigPath;

            Win32API.GetPrivateProfileString("Monitor", "MonitorFolderPath", "", stringBuilder, 256, fileConfig);
            monitorFolderPath = stringBuilder.ToString();
            if (!Directory.Exists(monitorFolderPath))
            {
                MessageBox.Show(string.Format("监听路径：{0}不存在", monitorFolderPath));
                Environment.Exit(0);
            }
        }

    }
}
