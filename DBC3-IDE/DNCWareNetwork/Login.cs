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
    ///The Login recording.
    /// </summary>
    [TestModule("bdaaa0ec-68f9-4264-93b6-15423e6375d6", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            PathDNCWARE = "D:\\ScriptAutomation\\DBC3-IDE\\Data\\admin.json";
            PasswordDNCWARE = "password";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _PathDNCWARE;

        /// <summary>
        /// Gets or sets the value of variable PathDNCWARE.
        /// </summary>
        [TestVariable("1a2c777c-d6af-4108-b6c8-9ecc14177b63")]
        public string PathDNCWARE
        {
            get { return _PathDNCWARE; }
            set { _PathDNCWARE = value; }
        }

        string _PasswordDNCWARE;

        /// <summary>
        /// Gets or sets the value of variable PasswordDNCWARE.
        /// </summary>
        [TestVariable("0a5d36dc-91c4-45d9-b240-9e7727832ce0")]
        public string PasswordDNCWARE
        {
            get { return _PasswordDNCWARE; }
            set { _PasswordDNCWARE = value; }
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

            MyTest1.Utils.logoutAndLogin(repo.DNCWAREBlockChain3.HomePage.Logout.LogoutButtonInfo, repo.DNCWAREBlockChain3.HomePage.Logout.OKButtonInfo, repo.DNCWAREBlockChain3.Login.WalletFileInfo, ValueConverter.ArgumentFromString<int>("duration", "3000"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$PathDNCWARE' on item 'DialogWindow.Text'.", repo.DialogWindow.TextInfo, new RecordItemIndex(2));
            repo.DialogWindow.Text.Element.SetAttributeValue("Text", PathDNCWARE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DialogWindow.ButtonOpen' at Center.", repo.DialogWindow.ButtonOpenInfo, new RecordItemIndex(4));
            repo.DialogWindow.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DNCWAREBlockChain3.Login.ButtonNext' at Center.", repo.DNCWAREBlockChain3.Login.ButtonNextInfo, new RecordItemIndex(6));
            repo.DNCWAREBlockChain3.Login.ButtonNext.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$PasswordDNCWARE' on item 'DNCWAREBlockChain3.Login.TextboxPassword'.", repo.DNCWAREBlockChain3.Login.TextboxPasswordInfo, new RecordItemIndex(8));
            repo.DNCWAREBlockChain3.Login.TextboxPassword.Element.SetAttributeValue("Value", PasswordDNCWARE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DNCWAREBlockChain3.Login.UnlockButton' at Center.", repo.DNCWAREBlockChain3.Login.UnlockButtonInfo, new RecordItemIndex(10));
            repo.DNCWAREBlockChain3.Login.UnlockButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
