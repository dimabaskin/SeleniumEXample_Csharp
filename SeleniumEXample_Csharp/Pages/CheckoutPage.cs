using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumEXample_Csharp.Types;
using NUnit.Framework;

namespace SeleniumEXample_Csharp.Pages
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }

        internal void RemoveAllProductsFromCart()
        {
            //6) удалить все товары из корзины один за другим, после каждого удаления подождать, пока внизу обновится таблица
            while (IsThereAnyItemtoRemove())
            {
                var SummaryBoxElement = Driver.FindElement(By.Id("box-checkout-summary"));
                Driver.FindElement(By.XPath("//button[@name='remove_cart_item']")).Click();
                wait.Until(ExpectedConditions.StalenessOf(SummaryBoxElement));
            }
            
        }

        private bool IsThereAnyItemtoRemove()
        {
            try
            {
                Driver.FindElement(By.Id("box-checkout-summary"));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
