using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegressionDemo
{
    public class Demo
    {
        [Test]
        [Category("Level1")]
        public void DoSearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://trailhead.salesforce.com/en/home";
            driver.Manage().Window.Maximize();
            IWebElement loginButtonElement = driver.FindElement(By.XPath("//button[text()='Login']"));
            (new WebDriverWait(driver, TimeSpan.FromSeconds(10))).Until(ExpectedConditions.ElementToBeClickable(loginButtonElement));
            loginButtonElement.Click();
            IWebElement loginWithSFButtonElement = driver.FindElement(By.Id("login_with_salesforce"));
            (new WebDriverWait(driver, TimeSpan.FromSeconds(10))).Until(ExpectedConditions.ElementToBeClickable(loginWithSFButtonElement));
            Assert.AreEqual("Salesforce", loginWithSFButtonElement.Text);
            driver.Quit();
        }
    }
}
