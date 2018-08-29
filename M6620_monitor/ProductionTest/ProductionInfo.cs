using Production.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Production.ProductionTest
{
    static class ProductionInfo
    {
        private static string configPath = ConfigInfo.ConfigPath;            //配置文件路径
        //manufature Info
        private static string customerName;             //客户名称
        private static string productModel;             //产品型号
        private static string planCode;                 //计划单号
    
        private static string procedure;                   //工序
        private static string station;                     //工位

        public static string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
                if (!string.IsNullOrEmpty(value))
                {
                    Win32API.WritePrivateProfileString("ProductionInfo", "CustomerName", customerName, configPath);
                }
            }
        }

        public static string ProductModel
        {
            get
            {
                return productModel;
            }

            set
            {
                productModel = value;
                if (!string.IsNullOrEmpty(value))
                {
                    Win32API.WritePrivateProfileString("ProductionInfo", "ProductModel", productModel, configPath);
                }
            }
        }

        public static string PlanCode
        {
            get
            {
                return planCode;
            }

            set
            {
                planCode = value;
                if (!string.IsNullOrEmpty(value))
                {
                    Win32API.WritePrivateProfileString("ProductionInfo", "PlanCode", planCode, configPath);
                }
            }
        }

        public static string Procedure
        {
            get
            {
                return procedure;
            }

            set
            {
                procedure = value;
            }
        }

        public static string Station
        {
            get
            {
                return station;
            }

            set
            {
                station = value;
            }
        }



        public static void ReadConfig()
        {
            StringBuilder stringBuilder = new StringBuilder();
            configPath = ConfigInfo.ConfigPath;

            //产品型号
            Win32API.GetPrivateProfileString("ProductionInfo", "ProductModel", "", stringBuilder, 256, configPath);
            productModel = stringBuilder.ToString().Trim();
            Win32API.GetPrivateProfileString("ProductionInfo", "CustomerName", "", stringBuilder, 256, configPath);
            customerName = stringBuilder.ToString().Trim();
            Win32API.GetPrivateProfileString("ProductionInfo", "PlanCode", "", stringBuilder, 256, configPath);
            planCode = stringBuilder.ToString().Trim();

            Win32API.GetPrivateProfileString("ProductionInfo", "Procedure", "", stringBuilder, 256, configPath);
            procedure = stringBuilder.ToString().Trim();
            Win32API.GetPrivateProfileString("ProductionInfo", "Station", "", stringBuilder, 256, configPath);
            station = stringBuilder.ToString().Trim();
        }

    }
}
