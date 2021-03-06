﻿using System;
using System.IO;
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
        internal WebDriverWait wait;

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
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var dir = Path.GetDirectoryName(typeof(BaseTest).Assembly.Location);
            Directory.SetCurrentDirectory(dir);

        }

       

      
        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
