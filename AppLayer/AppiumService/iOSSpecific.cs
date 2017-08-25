/*
 * Created by Ranorex
 * User: Z003RWZS
 * Date: 7/14/2017
 * Time: 11:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Remoting;
using Ranorex.Core.Testing;

namespace AppLayer.AppiumService
{
	/// <summary>
	/// Description of iOSSpecific.
	/// </summary>
	[TestModule("552CAF19-B9B2-4EBE-8D07-69DDBD89DC86", ModuleType.UserCode, 1)]
	public class iOSSpecific
	{
		IOSDriver<OpenQA.Selenium.Appium.iOS.IOSElement> driver = null;
		public static void LaunchiOSApp(Uri appiumServer, String udid, String bundleId,string appPath)
		{
			IOSDriver<OpenQA.Selenium.Appium.iOS.IOSElement> driver = null;
			DesiredCapabilities capabilities = new DesiredCapabilities();
			capabilities.SetCapability("device", "iOS");
			
			capabilities.SetCapability(CapabilityType.Platform, "Mac");
			capabilities.SetCapability("deviceName", "iPhone");
			capabilities.SetCapability("udid", udid);
			//capabilities.SetCapability("showIOSLog", true);
			capabilities.SetCapability("platformName", "iOS");
			//capabilities.SetCapability("app", "/Users/audiology/Desktop/MFApps.ipa");
			capabilities.SetCapability("app", appPath);
			//capabilities.SetCapability("app", "/Users/audiology/Desktop/MFApps.ipa");
			//capabilities.SetCapability("autoLaunch", true);
			capabilities.SetCapability("bundleId", bundleId);
			if(TestSuite.Current.Parameters["Version"].Equals("10",StringComparison.CurrentCultureIgnoreCase))
			{
				capabilities.SetCapability("automationName", "XCUITest");
				capabilities.SetCapability("xcodeConfigFile", "/Users/audiology/xcodeBuild.xcconfig");
			}
			else
				capabilities.SetCapability("automationName", "appium");
			
			capabilities.SetCapability("showIOSLog", "false");
			
			//capabilities.SetCapability("session", "true");
			//capabilities.SetCapability("fullReset", true);
			capabilities.SetCapability("noReset", true);
			try
			{
				driver = new IOSDriver<OpenQA.Selenium.Appium.iOS.IOSElement>(appiumServer, capabilities, TimeSpan.FromSeconds(180));
				Accessor.setDriver(driver);
				Ranorex.Report.Info("Launch iOS App", "Connected to Appium Server at " + appiumServer.ToString());
				
				if(TestSuite.Current.Parameters["isTablet"].Equals("True",StringComparison.CurrentCultureIgnoreCase))
					if((!TestSuite.Current.Parameters["Version"].Equals("10",StringComparison.CurrentCultureIgnoreCase)))
						((IOSDriver<IOSElement>)Accessor.getDriver()).Orientation=ScreenOrientation.Landscape;

				//	Accessor.getDriver().ExecuteScript("UIATarget.localTarget().setDeviceOrientation(UIA_DEVICE_ORIENTATION_PORTRAIT);");
				
			}catch(Exception ex){
				Ranorex.Report.Log(ReportLevel.Failure, ex.Message);
			}
			
		}
		
	}
}
