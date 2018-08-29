using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Production.Server;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Production.Server.HttpServerInfo.ReadConfig();
            NewHttpImeiPrint imeiPrint = new NewHttpImeiPrint();
            Production.Server.NewHttpImeiPrint.ResponseInfo rep;
            //int ret = imeiPrint.DataGetAndAnalysis(out rep, "865439030000610", "898602C99916C0366442", "123456789012345", "898602C99916C0366442", "CH04037470010061");

            int ret = imeiPrint.DataGetAndAnalysis(out rep, null, null, null, "898602C99916C0366442", null);
        }
    }
}
