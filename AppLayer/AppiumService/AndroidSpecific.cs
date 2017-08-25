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
    /// Description of AndroidSpecific.
    /// </summary>
    [TestModule("5AA34047-8858-4112-8A95-A9163B64872A", ModuleType.UserCode, 1)]
    public class AndroidSpecific
    {
        static AppiumLocalService service = null;
        static AndroidDriver<OpenQA.Selenium.Appium.Android.AndroidElement> driver = null;
        public static void ServiceStart()
		{
			//service = new OpenQA.Selenium.Appium.Service.AppiumServiceBuilder().UsingDriverExecutable(new FileInfo(@"C:\Program Files (x86)\Appium\node.exe")).WithAppiumJS(new FileInfo(@"C:\Program Files (x86)\Appium\node_modules\appium\bin\appium.js")).Build();
			/*			AppiumDriverLocalServicebuildService(new AppiumServiceBuilder()appium.js
     .usingDriverExecutable(new File(appiumInstallationDir + File.separator + "Appium" + File.separator + "node.exe"))
     .withAppiumJS(new File(appiumInstallationDir + File.separator + "Appium" + File.separator
       + "node_modules" + File.separator + "appium" + File.separator + "bin" + File.separator + "appium.js"))
     .withLogFile(new File(new File(classPathRoot, File.separator + "log"), "androidLog.txt")));*/
			
	
			service = OpenQA.Selenium.Appium.Service.AppiumLocalService.BuildDefaultService();
			service.Start();
		}
        
		public static void LaunchAndroidApp(String udid, String appPackage, String appActivity)
		{
			ServiceStart();
			//AndroidDriver<OpenQA.Selenium.Appium.Android.AndroidElement> driver = null;
			DesiredCapabilities capabilities = new DesiredCapabilities();
			capabilities.SetCapability("device", "Android");
			capabilities.SetCapability(CapabilityType.Platform, "Windows");
			capabilities.SetCapability("deviceName", "ABCD");
			capabilities.SetCapability("udid",udid);
			capabilities.SetCapability("platformName", "Android");
			
			capabilities.SetCapability("appPackage", appPackage);
			capabilities.SetCapability("appActivity", appActivity);

			capabilities.SetCapability("noReset", true);
			//	capabilities.SetCapability("fullReset", true);
			//	capabilities.SetCapability("app", @"C:\Ranorex\Apps\SIEMENS-Basic-Siemens Basic-Android-1.0.1.306.apk");
			//	capabilities.SetCapability("testobject_api_key", "B41E3492EF2C44A18CB0D9CD3C3DCEDC");
			//	capabilities.SetCapability("testobject_app_id", "2");
			//	capabilities.SetCapability("testobject_device", "LG_Nexus_4_E960_real");
			//capabilities.SetCapability("fullReset", false);
			try
			{
				driver = new AndroidDriver<OpenQA.Selenium.Appium.Android.AndroidElement>(service.ServiceUrl, capabilities, TimeSpan.FromSeconds(180));
				//Report.Info(driver.Capabilities.Platform.MajorVersion);
				//Report.Info("Platform Version "+driver.Capabilities.GetCapability("platformVersion"));////..getCapabilities().getCapability("platformVersion")
				//Report.Info("Device Name "+driver.Capabilities.GetCapability("deviceName"));
				//Report.Info("App Version "+driver.Capabilities.GetCapability(CapabilityType.Version));
				//driver.ResetApp();
				//driver = new AndroidDriver<OpenQA.Selenium.Appium.Android.AndroidElement>(new Uri("http://127.0.0.1:4719/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
				//driver = new AndroidDriver<OpenQA.Selenium.Appium.Android.AndroidElement>(new Uri("https://app.testobject.com:443/api/appium/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
				Accessor.setDriver(driver);
				
				
				Ranorex.Report.Info("Launch Android App", "Connected to Appium Server at " + service.ServiceUrl.ToString());
				
			}
			catch(Exception ex){
				Ranorex.Report.Log(ReportLevel.Failure, ex.Message);
			}
			
		}
        
        
        
    }
}
