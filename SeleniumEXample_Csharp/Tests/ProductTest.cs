using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using SeleniumEXample_Csharp.Pages;
using NUnit.Framework;


namespace SeleniumEXample_Csharp.Tests
{
    public class ProductTest : BaseTest
    {
        [Test]
        [TestCase(Category = "Product",
                  TestName = "Check All Products on Home Page Have Sticker",
                  Description = "Check All Products on Home Page Have Sticker.")]
        public void CheckAllProductsHaveSticker()
        {
            HomePage mainPage = new HomePage(driver);
            var ProductList = mainPage.FindAllProductsOnPage();
            mainPage.CheckProductHaveSticker(ProductList);
        }

        [Test]
        [TestCase(Category = "Product",
                  TestName = "Check First Product on Home Page is the same Product on Product Page",
                  Description = "Check First Product on Home Page is the same Product on Product Page")]
        public void FirstProductPropertiesTest()
        {
            HomePage mainPage = new HomePage(driver);
            ProductPage productPage = new ProductPage(driver);
            Product mainPageProduct = new Product();
            Product productPageProduct = new Product();
            var ProductList = mainPage.FindAllProductsOnPage();

            if (mainPage.ProductHaveStickerSale(ProductList[0]))
            {
                mainPageProduct = mainPage.GetSaleProductParameters(ProductList[0]);

            }
            else if (mainPage.ProductHaveStickerNew(ProductList[0]))
            {
                mainPageProduct = mainPage.GetNewProductParameters(ProductList[0]);
            }

            ProductList[0].Click();
            var product = productPage.GetProductElement();

            if (productPage.ProductHaveStickerSale(product))
            {
                productPageProduct = productPage.GetSaleProductParameters(product);
            }
            else if (productPage.ProductHaveStickerNew(product))
            {
                productPageProduct = productPage.GetNewProductParameters(product);
            }

            //Call Function to check the product sootvetstvuet opisaniu.
            NUnit.Framework.Assert.IsTrue(mainPageProduct.HaveRightProperties(), "Error - Product Properties on Home Page does not sute!!!");
            NUnit.Framework.Assert.IsTrue(productPageProduct.HaveRightProperties(), "Error - Product Properties on Home Page does not sute!!!");
            //Call Function to Compare 2 objects mainPageProduct and productPageProduct
            NUnit.Framework.Assert.IsTrue(mainPageProduct.Equals(productPageProduct), "Error - Product on Home Page does not sute the Procuct on Product Page!!!");



        }

        [Test]
        [TestCase(Category = "Product",
                  TestName = "Check each Product on Home Page is the same Product on Product Page",
                  Description = "Check each Product on Home Page is the same Product on Product Page")]
        public void AllProductPropertiesTest()
        {
            HomePage mainPage = new HomePage(driver);
            ProductPage productPage = new ProductPage(driver);
            Product mainPageProduct = new Product();
            Product productPageProduct = new Product();
            var ProductList = mainPage.FindAllProductsOnPage();

            for (int i=0; i < ProductList.Count; i++)
            {
                var newProductList = mainPage.FindAllProductsOnPage();

                if (mainPage.ProductHaveStickerSale(newProductList[i]))
                {
                    mainPageProduct = mainPage.GetSaleProductParameters(newProductList[i]);
                    
                }
                else if (mainPage.ProductHaveStickerNew(newProductList[i]))
                {
                    mainPageProduct = mainPage.GetNewProductParameters(newProductList[i]);
                }

                newProductList[i].Click();
                var product = productPage.GetProductElement();

                if(productPage.ProductHaveStickerSale(product))
                {
                    productPageProduct = productPage.GetSaleProductParameters(product);
                }
                else if(productPage.ProductHaveStickerNew(product))
                {
                    productPageProduct = productPage.GetNewProductParameters(product);
                }

                //Call Function to check the product sootvetstvuet opisaniu.
                NUnit.Framework.Assert.IsTrue(mainPageProduct.HaveRightProperties(),"Error - Product Properties on Home Page does not sute!!!");
                NUnit.Framework.Assert.IsTrue(productPageProduct.HaveRightProperties(), "Error - Product Properties on Home Page does not sute!!!");
                //Call Function to Compare 2 objects mainPageProduct and productPageProduct
                NUnit.Framework.Assert.IsTrue(mainPageProduct.Equals(productPageProduct), "Error - Product on Home Page does not sute the Procuct on Product Page!!!");
                
                productPage.BackToHomePage();
                
            }


            


        }
    }
}
