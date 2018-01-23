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
    public class ProductPage : BasePage
    {

        public ProductPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GetProductElement() => Driver.FindElement(By.Id("box-product"));

        public Product GetSaleProductParameters(IWebElement ProductElement)
        {
            Product product = new Product();
            var RegularPrice = ProductElement.FindElement(By.ClassName("regular-price"));
            var CampaignPrice = ProductElement.FindElement(By.ClassName("campaign-price"));

            product.ProductName = ProductElement.FindElement(By.ClassName("title")).Text;
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

            product.IsOnSaile = false;
            product.ProductName = ProductElement.FindElement(By.ClassName("title")).Text;
            product.RegularPrice.price = Price.Text;
            product.RegularPrice.isStrikethrough = Price.GetProperty("tagName").Equals("S");
            product.RegularPrice.SetColor(Price.GetCssValue("color"));
            product.RegularPrice.textStyle = Price.GetCssValue("font-weight");
            product.RegularPrice.SetTextSize(Price.GetCssValue("font-size"));


            return product;
        }

        internal void BackToHomePage()
        {
            Driver.Url = "http://localhost:8080/litecart/en/";
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
    }
}
