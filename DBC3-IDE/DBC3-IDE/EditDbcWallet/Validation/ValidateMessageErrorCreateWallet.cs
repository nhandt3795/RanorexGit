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

namespace DBC3_IDE.DBC3_IDE.EditDbcWallet.Validation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateMessageErrorCreateWallet recording.
    /// </summary>
    [TestModule("08e62fe9-e58c-4ab2-a59d-e3e5ea08366a", ModuleType.Recording, 1)]
    public partial class ValidateMessageErrorCreateWallet : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static ValidateMessageErrorCreateWallet instance = new ValidateMessageErrorCreateWallet();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateMessageErrorCreateWallet()
        {
            Expected = "Enter your Chain ID, wallet name and password and click the Create new button again.";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateMessageErrorCreateWallet Instance
        {
            get { return instance; }
        }

#region Variables

        string _Expected;

        /// <summary>
        /// Gets or sets the value of variable Expected.
        /// </summary>
        [TestVariable("71b282a5-c4aa-42f4-92b4-dd134223bde9")]
        public string Expected
        {
            get { return _Expected; }
            set { _Expected = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Expected) on item 'DBC3_IDE_DOMAIN.Info.EditDbcWallet.MessageError'.", repo.DBC3_IDE_DOMAIN.Info.EditDbcWallet.MessageErrorInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.DBC3_IDE_DOMAIN.Info.EditDbcWallet.MessageErrorInfo, "InnerText", Expected);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
