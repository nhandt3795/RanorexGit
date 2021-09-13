﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace DBC3_IDE.DNCWareNetwork.Click
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ClickDomainName recording.
    /// </summary>
    [TestModule("ec9e96ee-e5cf-439a-b732-db9ef7d3c92f", ModuleType.Recording, 1)]
    public partial class ClickDomainName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static ClickDomainName instance = new ClickDomainName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickDomainName()
        {
            DomainName = "@Domain1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickDomainName Instance
        {
            get { return instance; }
        }

#region Variables

        string _DomainName;

        /// <summary>
        /// Gets or sets the value of variable DomainName.
        /// </summary>
        [TestVariable("5765efc5-c76d-4eaf-ba88-69a2f6ac5651")]
        public string DomainName
        {
            get { return _DomainName; }
            set { _DomainName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DNCWAREBlockChain3.HomePage.DomainLink' at Center.", repo.DNCWAREBlockChain3.HomePage.DomainLinkInfo, new RecordItemIndex(0));
            repo.DNCWAREBlockChain3.HomePage.DomainLink.Click();
            Delay.Milliseconds(0);
            
            MyTest1.Utils.chooseDomain(repo.DNCWAREBlockChain3.DomainList.ListDomainNameInfo, DomainName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}