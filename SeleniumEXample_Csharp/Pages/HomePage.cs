using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumEXample_Csharp.Types;

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

        public IList<IWebElement> FindAllProductsOnMostPopularBoxHomePage()
        {
            var MostPopularBox = Driver.FindElement(By.Id("box-most-popular"));
            return MostPopularBox.FindElements(By.CssSelector("li.product.column.shadow.hover-light"));

        }

        public IList<IWebElement> FindAllProductsOnCampaignsBoxHomePage()
        {
            var CampaignsBox = Driver.FindElement(By.Id("box-campaigns"));
            return CampaignsBox.FindElements(By.CssSelector("li.product.column.shadow.hover-light"));

        }

        public IList<IWebElement> FindAllProductsOnLatestProductsBoxHomePage()
        {
            var LatestProductsBox = Driver.FindElement(By.Id("box-latest-products"));
            return LatestProductsBox.FindElements(By.CssSelector("li.product.column.shadow.hover-light"));

        }

        public void CheckProductHaveSticker(IList<IWebElement> ProductList)
        {
            List<string> ProductNames = new List<string>();

            foreach(var product in ProductList)
            {
                
               if ( product.FindElements(By.ClassName("sticker ")).Count != 1 )
                {
                    ProductNames.Add(product.FindElement(By.ClassName("name")).Text);
                }
                    
            }


            string products = string.Join(",", ProductNames.ToArray());
         
            NUnit.Framework.Assert.IsEmpty(ProductNames, "The Following Products Have no Sticker:  " + products);
        }

        public bool ProductHaveStickerNew(IWebElement ProductElement)
        {
            try
            {
                return ProductElement.FindElement(By.ClassName("sticker ")).GetAttribute("title").Contains("New");
            }
            catch
            {
                return false;
            }
            
        }


        public bool ProductHaveStickerSale(IWebElement ProductElement)
        {
            try
            {
                return ProductElement.FindElement(By.ClassName("sticker ")).GetAttribute("title").Contains("Sale");
            }
            catch
            {
                return false;
            }

        }

        public Product GetSaleProductParameters(IWebElement ProductElement)
        {
            Product product = new Product();
            var RegularPrice = ProductElement.FindElement(By.ClassName("regular-price"));
            var CampaignPrice = ProductElement.FindElement(By.ClassName("campaign-price"));

            product.ProductName = ProductElement.FindElement(By.ClassName("name")).Text;
            product.RegularPrice.price = RegularPrice.Text;
            product.RegularPrice.isStrikethrough = RegularPrice.GetProperty("tagName").Equals("S");
            product.RegularPrice.SetColor(RegularPrice.GetCssValue("color"));
            product.RegularPrice.textStyle = RegularPrice.GetCssValue("font-weight");
            product.RegularPrice.SetTextSize(RegularPrice.GetCssValue("font-size"));

            product.IsOnSaile = true;
            product.CampaignPrice.price = CampaignPrice.Text;
            product.CampaignPrice.isStrikethrough = CampaignPrice.GetProperty("tagName").Equals("S");
            product.CampaignPrice.SetColor(CampaignPrice.GetCssValue("color"));
            product.CampaignPrice.textStyle = CampaignPrice.GetCssValue("font-weight");
            product.CampaignPrice.SetTextSize(CampaignPrice.GetCssValue("font-size"));

            return product;
        }

        public Product GetNewProductParameters(IWebElement ProductElement)
        {
            Product product = new Product();
            var Price = ProductElement.FindElement(By.ClassName("price"));

            product.ProductName = ProductElement.FindElement(By.ClassName("name")).Text;
            product.RegularPrice.price = Price.Text;
            product.RegularPrice.isStrikethrough = Price.GetProperty("tagName").Equals("S");
            product.RegularPrice.SetColor(Price.GetCssValue("color"));
            product.RegularPrice.textStyle = Price.GetCssValue("font-weight");
            product.RegularPrice.SetTextSize(Price.GetCssValue("font-size"));
            product.IsOnSaile = false;


            return product;
        }
    }
}
