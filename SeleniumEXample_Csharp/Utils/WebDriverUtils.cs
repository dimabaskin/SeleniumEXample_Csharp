using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SeleniumEXample_Csharp.Utils
{
    public class WebDriverUtils
    {
        public void Unhide(IWebDriver driver, IWebElement element)
        {
            
            String script = "arguments[0].style.opacity=1;"
              + "arguments[0].style['transform']='translate(0px, 0px) scale(1)';"
              + "arguments[0].style['MozTransform']='translate(0px, 0px) scale(1)';"
              + "arguments[0].style['WebkitTransform']='translate(0px, 0px) scale(1)';"
              + "arguments[0].style['msTransform']='translate(0px, 0px) scale(1)';"
              + "arguments[0].style['OTransform']='translate(0px, 0px) scale(1)';"
              + "return true;";
            ((IJavaScriptExecutor)driver).ExecuteScript(script, element);
        }

        public void AttachFile(IWebDriver driver, By locator, String file)
        {
            IWebElement input = driver.FindElement(locator);
            Unhide(driver, input);
            input.SendKeys(file);
        }
    }
}
