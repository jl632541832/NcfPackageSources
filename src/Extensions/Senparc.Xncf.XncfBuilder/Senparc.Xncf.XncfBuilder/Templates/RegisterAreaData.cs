﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Xncf.XncfBuidler.Templates
{
    public partial class RegisterArea : IXncfTemplatePage
    {
        /// <summary>
        /// 相对地址
        /// </summary>
        public string RelativeFilePath => "Register.Area.cs";

        public string OrgName { get; set; }
        public string XncfName { get; set; }
        public bool UseSample { get; set; }
        public RegisterArea(string orgName, string xncfName,bool useSample)
        {
            OrgName = orgName;
            XncfName = xncfName;
            UseSample = useSample;
        }
    }
}
