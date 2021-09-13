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

namespace DBC3_IDE.DBC3_IDE.DomainCode
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FillDomainCode recording.
    /// </summary>
    [TestModule("d127fd8d-274d-4c33-a234-78c9825a22f7", ModuleType.Recording, 1)]
    public partial class FillDomainCode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static FillDomainCode instance = new FillDomainCode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FillDomainCode()
        {
            DomainCode = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FillDomainCode Instance
        {
            get { return instance; }
        }

#region Variables

        string _DomainCode;

        /// <summary>
        /// Gets or sets the value of variable DomainCode.
        /// </summary>
        [TestVariable("2aaf46b7-1fe8-4d91-8a53-b6f951d1df32")]
        public string DomainCode
        {
            get { return _DomainCode; }
            set { _DomainCode = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCode' at Center.", repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCodeInfo, new RecordItemIndex(0));
            repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCode'.", repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCodeInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCode);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCode'.", repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCodeInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCode);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DomainCode' with focus on 'DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCode'.", repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCodeInfo, new RecordItemIndex(6));
            repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCode.PressKeys(DomainCode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}