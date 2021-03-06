﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;


namespace SeleniumEXample_Csharp.Pages
{
    public class BasePage
    {
        internal IWebDriver Driver;
        internal WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
