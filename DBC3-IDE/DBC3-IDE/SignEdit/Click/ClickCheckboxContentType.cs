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

namespace DBC3_IDE.DBC3_IDE.SignEdit.Click
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ClickCheckboxContentType recording.
    /// </summary>
    [TestModule("4d6a6e1b-e576-4558-b5eb-b61326ae312c", ModuleType.Recording, 1)]
    public partial class ClickCheckboxContentType : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static ClickCheckboxContentType instance = new ClickCheckboxContentType();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickCheckboxContentType()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickCheckboxContentType Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DBC3_IDE_DOMAIN.EditDbcSignEdit.CheckBoxContentType' at Center.", repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.CheckBoxContentTypeInfo, new RecordItemIndex(0));
            repo.DBC3_IDE_DOMAIN.EditDbcSignEdit.CheckBoxContentType.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
