﻿using Newtonsoft.Json;
using Production.AllForms;
using Production.Result;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Production.ProductionTest
{
    class ViewControlers/* : IDisposable*/
    {
        private ITestFlow flow;
        private AllForms.FormMain frmMain;

        private string eid;

        private bool runState;

        public bool RunState
        {
            get
            {
                return runState;
            }

            set
            {
                runState = value;
            }
        }



        public ViewControlers(AllForms.FormMain frmMain, ITestFlow flow,string eid)
        {
            this.frmMain = frmMain;
            this.flow = flow;
            this.eid = eid;

            runState = false;
        }


        /// <summary>
        ///开启测试线程
        /// </summary>
        public void StartTest()
        {
            //测试开始
            runState = true;

            //开始测试
            int ret = flow.TestTaskFlow();

            //结果判断   
            Result.ResultJudge result = new Result.ResultJudge(frmMain);
            result.PutResult(ret);

            //Eid请求，获取Imei,iccid....，生成Log


            //生成Log
            Log.LogHelper log = new Log.LogHelper(frmMain);
            log.WriteLog(eid,ret);
                

            //测试完成
            runState = false;
        }

    }
}
