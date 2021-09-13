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

namespace DBC3_IDE.DNCWareNetwork.Click
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ClickUserNameFromUsersList recording.
    /// </summary>
    [TestModule("092ea9c3-d83d-4459-a630-f45a75cdb16b", ModuleType.Recording, 1)]
    public partial class ClickUserNameFromUsersList : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static ClickUserNameFromUsersList instance = new ClickUserNameFromUsersList();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickUserNameFromUsersList()
        {
            Domain = "@sandbox";
            UserName = "123123";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickUserNameFromUsersList Instance
        {
            get { return instance; }
        }

#region Variables

        string _Domain;

        /// <summary>
        /// Gets or sets the value of variable Domain.
        /// </summary>
        [TestVariable("32545bc2-2c1e-4816-9c7c-1f9f1432dbce")]
        public string Domain
        {
            get { return _Domain; }
            set { _Domain = value; }
        }

        string _UserName;

        /// <summary>
        /// Gets or sets the value of variable UserName.
        /// </summary>
        [TestVariable("75aa83ff-ea83-4947-abd8-0b00f51a77d8")]
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
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

            MyTest1.Utils.chooseUser(repo.DNCWAREBlockChain3.UsersList.ListUsersInfo, Domain, UserName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
