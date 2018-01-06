using System;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;



using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumEXample_Csharp
{
    [TestFixture]
    public class SimpleTest
    {

        private IWebDriver driver;
        private readonly string _driverType;
        private WebDriverWait whait;

        public SimpleTest()
        {
            _driverType = ConfigurationManager.AppSettings["driver"];
        }
        
        [SetUp]
        public void start()
        {
            switch(_driverType)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            whait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

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
            var test = driver.FindElement(By.Id("notices"));
            NUnit.Framework.Assert.IsTrue(test.FindElement(By.TagName("div")).Text.Contains("admin"), "Not ADMIN");

         }

      
        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
