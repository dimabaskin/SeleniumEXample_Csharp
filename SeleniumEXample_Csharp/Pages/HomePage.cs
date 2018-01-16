using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SeleniumEXample_Csharp.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            Driver.Url = "http://localhost:8080/litecart/en/";

        }

        public IList<IWebElement> FindAllProductsOnPage()
        {
            return Driver.FindElements(By.CssSelector("li.product.column.shadow.hover-light"));

        }

        public void CheckProductHaveSticker(IList<IWebElement> ProductList)
        {
            List<string> ProductNames = new List<string>();

            foreach(var product in ProductList)
            {
                try
                {
                    product.FindElement(By.ClassName("sticker "));
                }
                catch (NoSuchElementException ex)
                {
                    ProductNames.Add(product.FindElement(By.ClassName("name")).Text);
                    
                }
            }


            string products = string.Join(",", ProductNames.ToArray());
            
            NUnit.Framework.Assert.IsEmpty(ProductNames, "The Following Products Have no Sticker:  " + products);
        }
    }
}
