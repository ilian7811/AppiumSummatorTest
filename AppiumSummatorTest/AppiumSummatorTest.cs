using System;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumSummatorTest
{
    public class AppiumSummatorTest
    {
        public WindowsDriver<WindowsElement> driver;
        public static string AppiumServerAddress = "http://127.0.0.1:4723/wd/hub";
        //public AppiumOptions options;

        [TearDown]
        public void HhutDown()
        {
            driver.Quit();
        } 


        [SetUp]
        public void Setup()
        {
            var options = new AppiumOptions(){ PlatformName = "Windows" };            
            options.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\Ilqn\source\SummatorDesktopApp.exe");
            this.driver = new WindowsDriver<WindowsElement>(new Uri(AppiumServerAddress), options);
        }

        [Test]
        public void TestSummTwoPositiveNum()
        {
            Assert.Pass();
        }
    }
}// 23.5 -> 1:51