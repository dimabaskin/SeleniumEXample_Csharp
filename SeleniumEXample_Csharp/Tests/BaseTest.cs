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

namespace SeleniumEXample_Csharp.Tests
{
    [TestFixture]
    public class BaseTest
    {

        internal IWebDriver driver;
        private readonly string _driverType;
        internal WebDriverWait whait;

        public BaseTest()
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

       

      
        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
