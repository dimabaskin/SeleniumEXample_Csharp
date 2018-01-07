using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumEXample_Csharp.Tests
{
    public class SimpleTest:BaseTest
    {
        [Test]
        public void OpenBrowser()
        {
            driver.Url = "http://software-testing.ru/";
            //driver.FindElement(By.Name("q")).SendKeys("software-testing.ru" + Keys.Enter);
            //driver.FindElement(By.LinkText("http://software-testing.ru/")).Click();
            whait.Until(ExpectedConditions.TitleIs("Software-Testing.Ru"));
        }
    }
}
