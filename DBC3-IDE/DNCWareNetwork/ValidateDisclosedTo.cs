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

namespace DBC3_IDE.DNCWareNetwork
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateDisclosedTo recording.
    /// </summary>
    [TestModule("286132f0-f2f4-46d2-8de2-8c28f910ca72", ModuleType.Recording, 1)]
    public partial class ValidateDisclosedTo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static ValidateDisclosedTo instance = new ValidateDisclosedTo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateDisclosedTo()
        {
            DisclosedTo = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateDisclosedTo Instance
        {
            get { return instance; }
        }

#region Variables

        string _DisclosedTo;

        /// <summary>
        /// Gets or sets the value of variable DisclosedTo.
        /// </summary>
        [TestVariable("d8754066-c973-4881-b7f2-df5e9d1bd855")]
        public string DisclosedTo
        {
            get { return _DisclosedTo; }
            set { _DisclosedTo = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$DisclosedTo) on item 'DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.DisclosedTo'.", repo.DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.DisclosedToInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.DisclosedToInfo, "InnerText", DisclosedTo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
