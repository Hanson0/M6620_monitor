using Production.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Production
{
    class ConfigInfo
    {
        private static string configPath;     //配置文件的路径
        private static string configOfMesPath;//imes配置文件的路径
        private static string factoryId;         //
        private static string workOrderSn;    //
        private static string boxSn;    //
        private static string token;    //
        
        public static string ConfigPath
        {
            get
            {
                return configPath;
            }

            private set
            {
                configPath = value;
            }
        }
        public static string ConfigOfMesPath
        {
            get
            {
                return configOfMesPath;
            }

            private set
            {
                configOfMesPath = value;
            }
        }
        public static string FactoryId
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                Win32API.GetPrivateProfileString("Server", "factoryId", "", stringBuilder, 256, configOfMesPath);
                try
                {
                    factoryId = stringBuilder.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return factoryId;
            }
        }
        public static string WorkOrderSn
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                Win32API.GetPrivateProfileString("Server", "workOrderId", "", stringBuilder, 256, configOfMesPath);
                workOrderSn = stringBuilder.ToString();
                return workOrderSn;
            }
        }
        public static string BoxSn
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                Win32API.GetPrivateProfileString("Server", "boxSn", "", stringBuilder, 256, configOfMesPath);
                boxSn = stringBuilder.ToString();
                return boxSn;
            }
        }
        public static string Token
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                Win32API.GetPrivateProfileString("Server", "token", "", stringBuilder, 256, configOfMesPath);
                token = stringBuilder.ToString();
                return token;
            }
        }


        static ConfigInfo()
        {
            configPath = System.Environment.CurrentDirectory + "\\SetUp.ini";
            configOfMesPath = configPath.Replace("SetUp", "ConfigOfMes");
        }


        /// <summary>
        /// 初始化所有基础类的配置
        /// </summary>
        public static void Init()
        {
            try
            {
                Result.ResultInfo.ReadConfig();
                //ProductionTest.ProductionInfo.ReadConfig();
                Server.HttpServerInfo.ReadConfig();
                Log.LogInfo.ReadConfig();
                FolderMonitor.FolderMonitorInfo.ReadConfig();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Environment.Exit(0);
            }

        }


    }
}
