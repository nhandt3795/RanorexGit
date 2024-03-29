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
    ///The SetWalletForNewUser recording.
    /// </summary>
    [TestModule("939a5c2e-30ea-49dd-8a4d-76b9d4fdb610", ModuleType.Recording, 1)]
    public partial class SetWalletForNewUser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static SetWalletForNewUser instance = new SetWalletForNewUser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetWalletForNewUser()
        {
            Domain = "";
            Name = "";
            WallesAddress = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetWalletForNewUser Instance
        {
            get { return instance; }
        }

#region Variables

        string _Domain;

        /// <summary>
        /// Gets or sets the value of variable Domain.
        /// </summary>
        [TestVariable("1c6e0827-18ff-4a47-9869-32799062bace")]
        public string Domain
        {
            get { return _Domain; }
            set { _Domain = value; }
        }

        string _Name;

        /// <summary>
        /// Gets or sets the value of variable Name.
        /// </summary>
        [TestVariable("8f96afb7-6b40-42d3-9c71-a5edf47bde21")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        string _WallesAddress;

        /// <summary>
        /// Gets or sets the value of variable WallesAddress.
        /// </summary>
        [TestVariable("a5013809-a58c-49bb-984f-88bf76a38d06")]
        public string WallesAddress
        {
            get { return _WallesAddress; }
            set { _WallesAddress = value; }
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
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            MyTest1.Utils.chooseDomain(repo.DNCWAREBlockChain3.DomainList.ListDomainNameInfo, Domain);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            MyTest1.Utils.chooseUser(repo.DNCWAREBlockChain3.DomainList.DomainProfile.UsersListInfo, Domain, Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.ButtonEditWallets' at Center.", repo.DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.ButtonEditWalletsInfo, new RecordItemIndex(6));
            repo.DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.ButtonEditWallets.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$WallesAddress' on item 'DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.EditWallet.TextboxWalletAddress'.", repo.DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.EditWallet.TextboxWalletAddressInfo, new RecordItemIndex(8));
            repo.DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.EditWallet.TextboxWalletAddress.Element.SetAttributeValue("Value", WallesAddress);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.EditWallet.ButtonAdd' at Center.", repo.DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.EditWallet.ButtonAddInfo, new RecordItemIndex(10));
            repo.DNCWAREBlockChain3.DomainList.DomainProfile.UserProfile.EditWallet.ButtonAdd.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DNCWAREBlockChain3.HomePage.ButtonSubmit' at Center.", repo.DNCWAREBlockChain3.HomePage.ButtonSubmitInfo, new RecordItemIndex(12));
            repo.DNCWAREBlockChain3.HomePage.ButtonSubmit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(13));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
