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
    ///The DragAndDropDBCSign recording.
    /// </summary>
    [TestModule("9d7693ab-1d83-4981-afa5-6f85b10476cf", ModuleType.Recording, 1)]
    public partial class DragAndDropDBCSign : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DBC3_IDE.DBC3_IDERepository repository.
        /// </summary>
        public static global::DBC3_IDE.DBC3_IDERepository repo = global::DBC3_IDE.DBC3_IDERepository.Instance;

        static DragAndDropDBCSign instance = new DragAndDropDBCSign();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DragAndDropDBCSign()
        {
            Location = "Center";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DragAndDropDBCSign Instance
        {
            get { return instance; }
        }

#region Variables

        string _Location;

        /// <summary>
        /// Gets or sets the value of variable Location.
        /// </summary>
        [TestVariable("a9530192-187b-4542-9ad8-2ae4692cea40")]
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DBC3_IDE_DOMAIN.Dashboard.AddFlow' at Center.", repo.DBC3_IDE_DOMAIN.Dashboard.AddFlowInfo, new RecordItemIndex(0));
            repo.DBC3_IDE_DOMAIN.Dashboard.AddFlow.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'DBC3_IDE_DOMAIN.Nodes.dbc_sign' at Center.", repo.DBC3_IDE_DOMAIN.Nodes.dbc_signInfo, new RecordItemIndex(2));
            repo.DBC3_IDE_DOMAIN.Nodes.dbc_sign.MoveTo();
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'DBC3_IDE_DOMAIN.Dashboard.Dashboard' at position from variable $Location.", repo.DBC3_IDE_DOMAIN.Dashboard.DashboardInfo, new RecordItemIndex(4));
            repo.DBC3_IDE_DOMAIN.Dashboard.Dashboard.MoveTo(Location);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'DBC3_IDE_DOMAIN.Dashboard.Dashboard' at position from variable $Location.", repo.DBC3_IDE_DOMAIN.Dashboard.DashboardInfo, new RecordItemIndex(6));
            repo.DBC3_IDE_DOMAIN.Dashboard.Dashboard.MoveTo(Location);
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DBC3_IDE_DOMAIN.Dashboard.Dashboard' at position from variable $Location.", repo.DBC3_IDE_DOMAIN.Dashboard.DashboardInfo, new RecordItemIndex(8));
            repo.DBC3_IDE_DOMAIN.Dashboard.Dashboard.DoubleClick(Location);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
