using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SeleniumEXample_Csharp.Pages
{
    public class MainAdminPage : BasePage
    {
        public MainAdminPage(IWebDriver Driver) : base(Driver)
        {
            AdminLogin();
        }

        public void CheckAppearenceMenu()
        {
            // 1. Click on Appearence Menu
            var AppearenceMenu = FindElementInMenu("Appearence");
            if (AppearenceMenu is null){    NUnit.Framework.Assert.Fail("Appearence Menu not Exist on Page!!!"); }
            else                       {    AppearenceMenu.Click(); }
            CheckTitle("Template");
            
            //2. Click on Template subMenu
            Driver.FindElement(By.Id("doc-template")).Click();
            CheckTitle("Template");

            //3. click on Logotype subMenu
            Driver.FindElement(By.Id("doc-logotype")).Click();
            CheckTitle("Logotype");

        }

        public void CheckCatalogMenu()
        {
            // 1. Click on Catalog Menu
            var CatalogMenu = FindElementInMenu("Catalog");
            if (CatalogMenu is null) { NUnit.Framework.Assert.Fail("Catalog Menu not Exist on Page!!!"); }
            else { CatalogMenu.Click(); }
            CheckTitle("Catalog");

            // 2. Click on Catalog SubMenu
            Driver.FindElement(By.Id("doc-catalog")).Click();
            CheckTitle("Catalog");

            // 3. Click on  Product Groups SubMenu
            Driver.FindElement(By.Id("doc-product_groups")).Click();
            CheckTitle("Product Groups");

            // 4. Click on Option Groups SubMenu
            Driver.FindElement(By.Id("doc-option_groups")).Click();
            CheckTitle("Option Groups");

            // 5. Click on Manufacturers SubMenu
            Driver.FindElement(By.Id("doc-manufacturers")).Click();
            CheckTitle("Manufacturers");

            // 6. Click on Suppliers SubMenu
            Driver.FindElement(By.Id("doc-suppliers")).Click();
            CheckTitle("Suppliers");

            // 7. Click on Delivery Statuses SubMenu
            Driver.FindElement(By.Id("doc-delivery_statuses")).Click();
            CheckTitle("Delivery Statuses");

            // 8. Click on Sold Out Statuses SubMenu
            Driver.FindElement(By.Id("doc-sold_out_statuses")).Click();
            CheckTitle("Sold Out Statuses");

            // 9. Click on Quantity Units SubMenu
            Driver.FindElement(By.Id("doc-quantity_units")).Click();
            CheckTitle("Quantity Units");

            // 10. Click on CSV Import/Export SubMenu 
            Driver.FindElement(By.Id("doc-csv")).Click();
            CheckTitle("CSV Import/Export");
        }

        public void CheckCountriesMenu()
        {
            //1. Click on Countries Menu
            var CountriesMenu = FindElementInMenu("Countries");
            if (CountriesMenu is null) { NUnit.Framework.Assert.Fail("Countries Menu not Exist on Page!!!"); }
            else { CountriesMenu.Click(); }
            CheckTitle("Countries");
        }

        public void CheckCurrenciesMenu()
        {
            //1. Click on Currencies Menu
            var CurrenciesMenu = FindElementInMenu("Currencies");
            if (CurrenciesMenu is null) { NUnit.Framework.Assert.Fail("Currencies Menu not Exist on Page!!!"); }
            else { CurrenciesMenu.Click(); }
            CheckTitle("Currencies");
        }

        public void CheckCustomersMenu()
        {
            //1. Click on Customers Menu
            var CustomersMenu = FindElementInMenu("Customers");
            if (CustomersMenu is null) { NUnit.Framework.Assert.Fail("Customers Menu not Exist on Page!!!"); }
            else { CustomersMenu.Click(); }
            CheckTitle("Customers");

            //2. Click on Customers SubMenu doc-customers
            Driver.FindElement(By.Id("doc-customers")).Click();
            CheckTitle("Customers");

            //3. Click on CSV Import/Export SubMenu doc-csv
            Driver.FindElement(By.Id("doc-csv")).Click();
            CheckTitle("CSV Import/Export");

            //4. Click on Newsletter SubMenu doc-newsletter
            Driver.FindElement(By.Id("doc-newsletter")).Click();
            CheckTitle("Newsletter");

        }

        public void CheckGeoZonesMenu()
        {
            //1. Click on Geo Zones Menu
            var GeoZonesMenu = FindElementInMenu("Geo Zones");
            if (GeoZonesMenu is null) { NUnit.Framework.Assert.Fail("Geo Zones Menu not Exist on Page!!!"); }
            else { GeoZonesMenu.Click(); }
            CheckTitle("Geo Zones");
        }
        
        public void CheckLanguagesMenu()
        {
            //1. Click on Languages Menu
            var LanguagesMenu = FindElementInMenu("Languages");
            if (LanguagesMenu is null) { NUnit.Framework.Assert.Fail("Languages Menu not Exist on Page!!!"); }
            else { LanguagesMenu.Click(); }
            CheckTitle("Languages");

            //2. Click on Languages SubMenu doc-languages
            Driver.FindElement(By.Id("doc-languages")).Click();
            CheckTitle("Languages");

            //3. Click on Storage Encoding SubMenu doc-storage_encoding
            Driver.FindElement(By.Id("doc-storage_encoding")).Click();
            CheckTitle("Storage Encoding");
        }

        public void CheckModulesMenu()
        {
            //1. Click on Modules Menu
            var ModulesMenu = FindElementInMenu("Modules");
            if (ModulesMenu is null) { NUnit.Framework.Assert.Fail("Modules Menu not Exist on Page!!!"); }
            else { ModulesMenu.Click(); }
            CheckTitle("Job Modules");

            //2. Click on Background Jobs SubMenu doc-jobs
            Driver.FindElement(By.Id("doc-jobs")).Click();
            CheckTitle("Job Modules");

            //3. Click on Customer SubMenu doc-customer
            Driver.FindElement(By.Id("doc-customer")).Click();
            CheckTitle("Customer Modules");

            //4. Click on Shipping SubMenu doc-shipping
            Driver.FindElement(By.Id("doc-shipping")).Click();
            CheckTitle("Shipping Modules");

            //5. Click on Payment SubMenu doc-payment
            Driver.FindElement(By.Id("doc-payment")).Click();
            CheckTitle("Payment Modules");

            //6. Click on Order Total SubMenu  doc-order_total
            Driver.FindElement(By.Id("doc-order_total")).Click();
            CheckTitle("Order Total Modules");

            //7. Click on Order Success SubMenu doc-order_success
            Driver.FindElement(By.Id("doc-order_success")).Click();
            CheckTitle("Order Success Modules");

            //8. Click on Order Action SubMenu doc-order_action
            Driver.FindElement(By.Id("doc-order_action")).Click();
            CheckTitle("Order Action Modules");


        }

        public void CheckOrdersMenu()
        {
            //1. Click on Orders Menu
            var OrdersMenu = FindElementInMenu("Orders");
            if (OrdersMenu is null) { NUnit.Framework.Assert.Fail("Orders Menu not Exist on Page!!!"); }
            else { OrdersMenu.Click(); }
            CheckTitle("Orders");

            //2. Click on Orders SubMenu doc-orders
            Driver.FindElement(By.Id("doc-orders")).Click();
            CheckTitle("Orders");

            //3. Click on Order Statuses SubMenu doc-order_statuses
            Driver.FindElement(By.Id("doc-order_statuses")).Click();
            CheckTitle("Order Statuses");

        }

        public void CheckPagesMenu()
        {
            //1. Click on Pages Menu
            var PagesMenu = FindElementInMenu("Pages");
            if (PagesMenu is null) { NUnit.Framework.Assert.Fail("Pages Menu not Exist on Page!!!"); }
            else { PagesMenu.Click(); }
            CheckTitle("Pages");

        }

        public void CheckReportsMenu()
        {
            //1. Click on Reports Menu
            var ReportsMenu = FindElementInMenu("Reports");
            if (ReportsMenu is null) { NUnit.Framework.Assert.Fail("Reports Menu not Exist on Page!!!"); }
            else { ReportsMenu.Click(); }
            CheckTitle("Monthly Sales");

            //2. Click on Monthly Sales SubMenu doc-monthly_sales
            Driver.FindElement(By.Id("doc-monthly_sales")).Click();
            CheckTitle("Monthly Sales");

            //3. Click on Most Sold Products SubMenu doc-most_sold_products
            Driver.FindElement(By.Id("doc-most_sold_products")).Click();
            CheckTitle("Most Sold Products");

            //4. Click on Most Shopping Customers SubMenu doc-most_shopping_customers
            Driver.FindElement(By.Id("doc-most_shopping_customers")).Click();
            CheckTitle("Most Shopping Customers");


        }

        public void CheckSettingsMenu()
        {
            //1. Click on Settings Menu
            var SettingsMenu = FindElementInMenu("Settings");
            if (SettingsMenu is null) { NUnit.Framework.Assert.Fail("Settings Menu not Exist on Page!!!"); }
            else { SettingsMenu.Click(); }
            CheckTitle("Settings");

            //2. Click on Store Info SubMenu doc-store_info
            Driver.FindElement(By.Id("doc-store_info")).Click();
            CheckTitle("Settings");

            //3. Click on Defaults SubMenu doc-defaults
            Driver.FindElement(By.Id("doc-defaults")).Click();
            CheckTitle("Settings");

            //4. Click on General  SubMenu doc-general
            Driver.FindElement(By.Id("doc-general")).Click();
            CheckTitle("Settings");

            //5. Click on Listings SubMenu doc-listings
            Driver.FindElement(By.Id("doc-listings")).Click();
            CheckTitle("Settings");

            //6. Click on Images SubMenu doc-images
            Driver.FindElement(By.Id("doc-images")).Click();
            CheckTitle("Settings");

            //7. Click on Checkout SubMenu doc-checkout
            Driver.FindElement(By.Id("doc-checkout")).Click();
            CheckTitle("Settings");

            //8. Click on Advanced SubMenu doc-advanced
            Driver.FindElement(By.Id("doc-advanced")).Click();
            CheckTitle("Settings");

            //9. Click on Security SubMenu doc-security 
            Driver.FindElement(By.Id("doc-security")).Click();
            CheckTitle("Settings");


        }

        public void CheckSlidesMenu()
        {
            //1. Click on Slides Menu
            var SlidesMenu = FindElementInMenu("Slides");
            if (SlidesMenu is null) { NUnit.Framework.Assert.Fail("Slides Menu not Exist on Page!!!"); }
            else { SlidesMenu.Click(); }
            CheckTitle("Slides");

        }

        public void CheckTaxMenu()
        {
            //1. Click on Tax Menu
            var TaxMenu = FindElementInMenu("Tax");
            if (TaxMenu is null) { NUnit.Framework.Assert.Fail("Tax Menu not Exist on Page!!!"); }
            else { TaxMenu.Click(); }
            CheckTitle("Tax Classes");

            //2. Click on Tax Classes SubMenu doc-tax_classes
            Driver.FindElement(By.Id("doc-tax_classes")).Click();
            CheckTitle("Tax Classes");

            //3. Click on Tax Rates Statuses SubMenu doc-tax_rates
            Driver.FindElement(By.Id("doc-tax_rates")).Click();
            CheckTitle("Tax Rates");

        }

        public void CheckTranslationsMenu()
        {
            //1. Click on Translations Menu
            var TranslationsMenu = FindElementInMenu("Translations");
            if (TranslationsMenu is null) { NUnit.Framework.Assert.Fail("Translations Menu not Exist on Page!!!"); }
            else { TranslationsMenu.Click(); }
            CheckTitle("Search Translations");

            //2. Click on Search Translations SubMenu doc-search
            Driver.FindElement(By.Id("doc-search")).Click();
            CheckTitle("Search Translations");

            //3. Click on Scan Files SubMenu doc-scan
            Driver.FindElement(By.Id("doc-scan")).Click();
            CheckTitle("Scan Files For Translations");

            //4. Click on CSV Import/Export SubMenu doc-csv
            Driver.FindElement(By.Id("doc-csv")).Click();
            CheckTitle("CSV Import/Export");
        }

        public void CheckUsersMenu()
        {
            //1. Click on Users Menu
            var UsersMenu = FindElementInMenu("Users");
            if (UsersMenu is null) { NUnit.Framework.Assert.Fail("Users Menu not Exist on Page!!!"); }
            else { UsersMenu.Click(); }
            CheckTitle("Users");

        }

        public void CheckvQmodsMenu()
        {
            //1. Click on vQmods Menu
            var vQmodsMenu = FindElementInMenu("vQmods");
            if (vQmodsMenu is null) { NUnit.Framework.Assert.Fail("vQmods Menu not Exist on Page!!!"); }
            else { vQmodsMenu.Click(); }
            CheckTitle("vQmods");

            //2. Click on vQmods SubMenu doc-vqmods
            Driver.FindElement(By.Id("doc-vqmods")).Click();
            CheckTitle("vQmods");

        }

        public void AdminLogin()
        {
            Driver.Url = "http://localhost:8080/litecart/admin/login.php";
            Driver.FindElement(By.Name("username")).SendKeys("admin");
            Driver.FindElement(By.Name("password")).SendKeys("admin");
            Driver.FindElement(By.Name("login")).Click();
            var test = Driver.FindElement(By.Id("notices"));
            NUnit.Framework.Assert.IsTrue(test.FindElement(By.TagName("div")).Text.Contains("admin"), "Not ADMIN");

        }

        private void CheckTitle(string Title)
        {
            var title = Driver.FindElement(By.TagName("h1"));
            NUnit.Framework.Assert.IsTrue(title.Text.Equals(Title),"Title: " + Title + " Not Found On Page.");
            
        }

        private IWebElement FindElementInMenu(string elementName)
        {
            var MenuList = Driver.FindElements(By.ClassName("name"));
            foreach (var menu in MenuList)
            {
                if (menu.Text.Equals(elementName))
                {
                    return menu;
                }
            }
            return null;
        }

        public void ClickOnAllMenus()
        {
            var MenuList = Driver.FindElements(By.Id("app-"));
            List<string> MenuName = new List<string>();
            foreach (var menu in MenuList)
            {
                MenuName.Add(menu.Text);

            }

            foreach(string name in MenuName)
            {
                FindElementInMenu(name).Click();
                var title = Driver.FindElement(By.TagName("h1"));

                List<string> SubMenuName = new List<string>();
                var SubMenuList = Driver.FindElements(By.XPath("//li[starts-with(@id,'doc-')]"));
                if (SubMenuList.Count > 0)
                {
                    foreach (var menu in SubMenuList)
                    {
                        SubMenuName.Add(menu.Text);
                    }
                    foreach(string subname in SubMenuName)
                    {
                        FindElementInMenu(subname).Click();
                        var subtitle = Driver.FindElement(By.TagName("h1"));
                    }
                }

            }
        }
   }
}
