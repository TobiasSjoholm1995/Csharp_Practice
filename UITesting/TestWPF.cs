using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProjectWPF;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Windows;

namespace UITesting {

    [TestClass]
    public class TestWPF {

        [TestMethod]
        public void TestMethod1() {

            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            var CalculatorSession = new WindowsDriver<WindowsElement>(appCapabilities);

            Assert.IsNotNull(CalculatorSession);

            CalculatorSession.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));

            CalculatorSession.FindElementByName("MyButton").Click();
            Assert.AreEqual("Clicked", CalculatorSession.FindElementByName("MyTextBlock").Text);
        }
    }
}
