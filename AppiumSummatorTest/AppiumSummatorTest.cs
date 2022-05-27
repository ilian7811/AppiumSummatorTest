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
        public AppiumOptions options;
        
        
        [SetUp]
        public void Setup()
        {
            this.options = new AppiumOptions(){ PlatformName = "Windows" };            
            options.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\Ilqn\source\SummatorDesktopApp.exe");
            this.driver = new WindowsDriver<WindowsElement>(new Uri(AppiumServerAddress), options);
        }

        [Test]
        public void TestSummTwoPositiveNum()
        {
            Assert.Pass();
        }
    }
}