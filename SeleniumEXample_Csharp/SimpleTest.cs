using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumEXample_Csharp
{
    [TestFixture]
    public class SimpleTest
    {

        private IWebDriver driver;
        private WebDriverWait whait;
        
        [SetUp]
        public void start()
        {
            driver = new ChromeDriver();
            whait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        }


        [Test]
        public void OpenBrowser()
        {
            driver.Url = "http://software-testing.ru/";
            //driver.FindElement(By.Name("q")).SendKeys("software-testing.ru" + Keys.Enter);
            //driver.FindElement(By.LinkText("http://software-testing.ru/")).Click();
            whait.Until(ExpectedConditions.TitleIs("Software-Testing.Ru"));
        }


        [Test]
        public void  AdminLogin()
        {
            driver.Url = "http://localhost:8080/litecart/admin/login.php";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();

         }

      
        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
