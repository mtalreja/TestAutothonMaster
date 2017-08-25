/*
 * Created by Ranorex
 * User: Z002XFCE
 * Date: 8/25/2017
 * Time: 4:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using AppLayer.AppiumService;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace AppLayer.Modules
{
    /// <summary>
    /// Description of Teardown.
    /// </summary>
    [TestModule("1CF765B0-1571-4058-821C-7DC35E94D48A", ModuleType.UserCode, 1)]
    public class Teardown : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Teardown()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            if(Accessor.getDriver()!=null)
			{				
				Accessor.getDriver().Quit();
			}
            
			
        }
    }
}
