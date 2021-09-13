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

namespace DBC3_IDE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("7b1888b6-c432-49d4-9dbd-7411fafcce98", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DBC3_IDERepository repository.
        /// </summary>
        public static DBC3_IDERepository repo = DBC3_IDERepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            NewVariable = "True";
            sandboxValue = "";
            NewVariable1 = "@Domain1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _NewVariable;

        /// <summary>
        /// Gets or sets the value of variable NewVariable.
        /// </summary>
        [TestVariable("1e6c60d1-4557-40c7-8f03-59ebbf5df5c1")]
        public string NewVariable
        {
            get { return _NewVariable; }
            set { _NewVariable = value; }
        }

        string _sandboxValue;

        /// <summary>
        /// Gets or sets the value of variable sandboxValue.
        /// </summary>
        [TestVariable("cac2b305-b60a-4c9d-8189-339a988706b4")]
        public string sandboxValue
        {
            get { return _sandboxValue; }
            set { _sandboxValue = value; }
        }

        string _NewVariable1;

        /// <summary>
        /// Gets or sets the value of variable NewVariable1.
        /// </summary>
        [TestVariable("fd4607de-63c7-42df-ac8d-e758dd1ff2a1")]
        public string NewVariable1
        {
            get { return _NewVariable1; }
            set { _NewVariable1 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='123123') on item 'DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCode'.", repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCodeInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.DBC3_IDE_DOMAIN.Info.EditDbcDomain.FunctionCodeInfo, "InnerText", "123123");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
