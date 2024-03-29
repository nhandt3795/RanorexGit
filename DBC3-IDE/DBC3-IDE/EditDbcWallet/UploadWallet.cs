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

namespace DBC3_IDE.DBC3_IDE.EditDbcWallet
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UploadWallet recording.
    /// </summary>
    [TestModule("dc55002b-5a48-4c1c-a375-c444e152d1ec", ModuleType.Recording, 1)]
    public partial class UploadWallet : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static UploadWallet instance = new UploadWallet();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UploadWallet()
        {
            Path = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UploadWallet Instance
        {
            get { return instance; }
        }

#region Variables

        string _Path;

        /// <summary>
        /// Gets or sets the value of variable Path.
        /// </summary>
        [TestVariable("8c90c64d-9051-401f-ba65-23039ecb0ce8")]
        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DBC3_IDE_DOMAIN.Info.EditDbcWallet.UploadWallet' at Center.", repo.DBC3_IDE_DOMAIN.Info.EditDbcWallet.UploadWalletInfo, new RecordItemIndex(0));
            repo.DBC3_IDE_DOMAIN.Info.EditDbcWallet.UploadWallet.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Path' on item 'DialogWindow.Text'.", repo.DialogWindow.TextInfo, new RecordItemIndex(2));
            repo.DialogWindow.Text.Element.SetAttributeValue("Text", Path);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DialogWindow.ButtonOpen' at Center.", repo.DialogWindow.ButtonOpenInfo, new RecordItemIndex(4));
            repo.DialogWindow.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
