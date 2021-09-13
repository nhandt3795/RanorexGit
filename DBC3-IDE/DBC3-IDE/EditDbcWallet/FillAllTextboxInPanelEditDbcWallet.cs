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
    ///The FillAllTextboxInPanelEditDbcWallet recording.
    /// </summary>
    [TestModule("1bc4bce9-1e3f-4711-bd84-e7ca3ca10733", ModuleType.Recording, 1)]
    public partial class FillAllTextboxInPanelEditDbcWallet : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static FillAllTextboxInPanelEditDbcWallet instance = new FillAllTextboxInPanelEditDbcWallet();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FillAllTextboxInPanelEditDbcWallet()
        {
            Name = "";
            ChainID = "";
            Password = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FillAllTextboxInPanelEditDbcWallet Instance
        {
            get { return instance; }
        }

#region Variables

        string _Name;

        /// <summary>
        /// Gets or sets the value of variable Name.
        /// </summary>
        [TestVariable("b919a121-186e-4b34-b19a-b58660848cf1")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        string _ChainID;

        /// <summary>
        /// Gets or sets the value of variable ChainID.
        /// </summary>
        [TestVariable("03ba12b8-f2b1-44be-9487-2211d01e6df1")]
        public string ChainID
        {
            get { return _ChainID; }
            set { _ChainID = value; }
        }

        string _Password;

        /// <summary>
        /// Gets or sets the value of variable Password.
        /// </summary>
        [TestVariable("99ae9565-15ea-495e-88af-db6761d4298c")]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$Name' on item 'DBC3_IDE_DOMAIN.Info.Name'.", repo.DBC3_IDE_DOMAIN.Info.NameInfo, new RecordItemIndex(0));
            repo.DBC3_IDE_DOMAIN.Info.Name.Element.SetAttributeValue("Value", Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$ChainID' on item 'DBC3_IDE_DOMAIN.Info.EditDbcWallet.ChainID'.", repo.DBC3_IDE_DOMAIN.Info.EditDbcWallet.ChainIDInfo, new RecordItemIndex(2));
            repo.DBC3_IDE_DOMAIN.Info.EditDbcWallet.ChainID.Element.SetAttributeValue("Value", ChainID);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$Password' on item 'DBC3_IDE_DOMAIN.Info.EditDbcWallet.Password'.", repo.DBC3_IDE_DOMAIN.Info.EditDbcWallet.PasswordInfo, new RecordItemIndex(4));
            repo.DBC3_IDE_DOMAIN.Info.EditDbcWallet.Password.Element.SetAttributeValue("Value", Password);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
