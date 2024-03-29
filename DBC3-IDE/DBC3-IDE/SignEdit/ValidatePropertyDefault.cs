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

namespace DBC3_IDE.DBC3_IDE.SignEdit
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidatePropertyDefault recording.
    /// </summary>
    [TestModule("831bf5f2-c699-4858-b3f3-829eea593fca", ModuleType.Recording, 1)]
    public partial class ValidatePropertyDefault : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static ValidatePropertyDefault instance = new ValidatePropertyDefault();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatePropertyDefault()
        {
            TagValueWallet = "_ADD_";
            Checked = "False";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidatePropertyDefault Instance
        {
            get { return instance; }
        }

#region Variables

        string _TagValueWallet;

        /// <summary>
        /// Gets or sets the value of variable TagValueWallet.
        /// </summary>
        [TestVariable("107056aa-847c-4739-b8bb-99328b4adb29")]
        public string TagValueWallet
        {
            get { return _TagValueWallet; }
            set { _TagValueWallet = value; }
        }

        string _Checked;

        /// <summary>
        /// Gets or sets the value of variable Checked.
        /// </summary>
        [TestVariable("4c742704-964c-443b-81c4-9fe068b81f4c")]
        public string Checked
        {
            get { return _Checked; }
            set { _Checked = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='(null)') on item 'DBC3_IDE_DOMAIN.EditDbcSignEdit.Name'.", repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.NameInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.NameInfo, "TagValue", (string)null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$TagValueWallet) on item 'DBC3_IDE_DOMAIN.EditDbcSignEdit.SelectWallet'.", repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.SelectWalletInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.SelectWalletInfo, "TagValue", TagValueWallet);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='(null)') on item 'DBC3_IDE_DOMAIN.EditDbcSignEdit.ContractID'.", repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.ContractIDInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.ContractIDInfo, "TagValue", (string)null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked=$Checked) on item 'DBC3_IDE_DOMAIN.EditDbcSignEdit.CheckBoxContentType'.", repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.CheckBoxContentTypeInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.CheckBoxContentTypeInfo, "Checked", Checked);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
