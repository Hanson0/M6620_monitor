using Production;
using Production.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Production.Log
{
    class LogInfo
    {
        private static string configPath;
        private static string folderLog;

        public static string FolderLog
        {
            get
            {
                return folderLog;
            }

            private set
            {
                folderLog = value;
            }
        }



        public static void ReadConfig()
        {
            configPath = ConfigInfo.ConfigPath;            //配置文件路径
            StringBuilder stringBuilder = new StringBuilder();

            Win32API.GetPrivateProfileString("Path", "LogPath", "", stringBuilder, 256, configPath);
            folderLog = stringBuilder.ToString().Trim();

            //若有创建LOG路径，则创建
            if (!Directory.Exists(folderLog))
            {
                Directory.CreateDirectory(folderLog);
            }
        }
    }
}
