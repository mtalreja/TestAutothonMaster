/*
 * Created by Ranorex
 * User: Z002XFCE
 * Date: 8/25/2017
 * Time: 3:24 PM
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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Remoting;
using Ranorex.Core.Testing;

namespace AppLayer.AppiumService
{
	/// <summary>
	/// Description of WebSpecific.
	/// </summary>
	public class WebSpecific
	{
		static IWebDriver driver= null;
		
		public WebSpecific()
		{
		}
		
		public static void LaunchWeb(String browser, String webURL)
		{
			try
			{
				//System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Framework\TestAutomation\External\Drivers\chromedriver.exe");
				string p=Path.GetFullPath(@"..\..\..\External\Drivers\");
				if(browser.Equals("chrome",StringComparison.CurrentCultureIgnoreCase))
					driver= new ChromeDriver(Path.GetFullPath(@"..\..\..\External\Drivers\"));
				Accessor.setDriver(driver);
				driver.Navigate().GoToUrl(webURL);
				Logger.logInfo("Launch web browser" + webURL);
			}
			catch(Exception ex){
				Ranorex.Report.Log(ReportLevel.Info, ex.Message);
			}
			
		}
		
		public static void SelectComboBoxItem(By by, string pSelectText)
		{
			var webElem = KeywordImplementation.UIObject(by);
			if (webElem.TagName == "select")
			{
				SelectElement lvSelectElem = new SelectElement(webElem);
				lvSelectElem.SelectByText(pSelectText);
				return;
			}
			Report.Log(ReportLevel.Info, "Select is not supported, please investigate.");
		}

		public static IList<IWebElement> GetComboBoxElements(By by)
		{
			var webElem = KeywordImplementation.UIObject(by);
			if (webElem.TagName == "select")
			{
				SelectElement lvSelectElem = new SelectElement(webElem);
				return lvSelectElem.Options;
			}
			Report.Log(ReportLevel.Info, "Select is not supported, please investigate.");
			return null;
		}
		
		public static string GetSelectedComboboxValue(By by)
		{
			var webElem = KeywordImplementation.UIObject(by);
			if (webElem.TagName == "select")
			{
				SelectElement lvSelectElem = new SelectElement(webElem);
				return lvSelectElem.SelectedOption.Text;
			}
			Report.Log(ReportLevel.Info, "Select is not supported, please investigate.");
			return null;
		}
	}
}
