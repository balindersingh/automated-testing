using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        [Category("bug")]
        public void DoSearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.bing.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.ClassName("b_searchbox")).SendKeys("formstack");
            driver.FindElement(By.ClassName("b_searchboxSubmit")).Click();
            Assert.AreEqual("Formstack", driver.FindElement(By.Id("b_context")).FindElement(By.ClassName(" b_entityTitle")).Text);
            driver.Quit();
        }
        [Test]
        [Category("bug")]
        public void DoSearch2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.bing.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.ClassName("b_searchbox")).SendKeys("formstack");
            driver.FindElement(By.ClassName("b_searchboxSubmit")).Click();
            Assert.AreEqual("Formstack", driver.FindElement(By.Id("b_context")).FindElement(By.ClassName(" b_entityTitle")).Text);
            driver.Quit();
        }
        [Test]
        [Category("bug")]
        public void DoSearch3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.bing.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.ClassName("b_searchbox")).SendKeys("formstack");
            driver.FindElement(By.ClassName("b_searchboxSubmit")).Click();
            Assert.AreEqual("Formstack", driver.FindElement(By.Id("b_context")).FindElement(By.ClassName(" b_entityTitle")).Text);
            driver.Quit();
        }
    }
}
