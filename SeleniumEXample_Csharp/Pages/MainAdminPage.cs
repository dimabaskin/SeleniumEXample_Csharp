using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Collections.ObjectModel;

namespace SeleniumEXample_Csharp.Pages
{
    public class MainAdminPage : BasePage
    {

        public MainAdminPage(IWebDriver Driver) : base(Driver)
        {
            AdminLogin();
        }

        public void ClickOnAllMenus()
        {
            var MenuList = Driver.FindElements(By.Id("app-"));
            List<string> MenuName = new List<string>();
            foreach (var menu in MenuList)
            {
                MenuName.Add(menu.Text);

            }

            foreach (string name in MenuName)
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
                    foreach (string subname in SubMenuName)
                    {
                        FindElementInMenu(subname).Click();
                        var subtitle = Driver.FindElement(By.TagName("h1"));
                    }
                }

            }
        }

        public void CheckAppearenceMenu()
        {
            // 1. Click on Appearence Menu
            ClickOnMenu("Appearence", "Template");

            //2. Click on Template subMenu
            ClickOnSubMenu("doc-template", "Template");

            //3. click on Logotype subMenu
            ClickOnSubMenu("doc-logotype", "Logotype");
            
        }

        public void CheckCatalogMenu()
        {
            // 1. Click on Catalog Menu
            ClickOnMenu("Catalog");

            // 2. Click on Catalog SubMenu
            ClickOnSubMenu("doc-catalog", "Catalog");
            
            // 3. Click on  Product Groups SubMenu
            ClickOnSubMenu("doc-product_groups", "Product Groups");
            
            // 4. Click on Option Groups SubMenu
            ClickOnSubMenu("doc-option_groups", "Option Groups");

            // 5. Click on Manufacturers SubMenu
            ClickOnSubMenu("doc-manufacturers", "Manufacturers");

            // 6. Click on Suppliers SubMenu
            ClickOnSubMenu("doc-suppliers", "Suppliers");

            // 7. Click on Delivery Statuses SubMenu
            ClickOnSubMenu("doc-delivery_statuses", "Delivery Statuses");

            // 8. Click on Sold Out Statuses SubMenu
            ClickOnSubMenu("doc-sold_out_statuses", "Sold Out Statuses");

            // 9. Click on Quantity Units SubMenu
            ClickOnSubMenu("doc-quantity_units", "Quantity Units");

            // 10. Click on CSV Import/Export SubMenu 
            ClickOnSubMenu("doc-csv", "CSV Import/Export");
        }

        public void CheckCountriesMenu()
        {
            //1. Click on Countries Menu
            ClickOnMenu("Countries");
            
        }

        public void CheckCurrenciesMenu()
        {
            //1. Click on Currencies Menu
            ClickOnMenu("Currencies");
            
        }

        public void CheckCustomersMenu()
        {
            //1. Click on Customers Menu
            ClickOnMenu("Customers");

            //2. Click on Customers SubMenu doc-customers
            ClickOnSubMenu("doc-customers", "Customers");

            //3. Click on CSV Import/Export SubMenu doc-csv
            ClickOnSubMenu("doc-csv", "CSV Import/Export");

            //4. Click on Newsletter SubMenu doc-newsletter
            ClickOnSubMenu("doc-newsletter", "Newsletter");

        }

        public void CheckGeoZonesMenu()
        {
            //1. Click on Geo Zones Menu
            ClickOnMenu("Geo Zones");
            
        }
        
        public void CheckLanguagesMenu()
        {
            //1. Click on Languages Menu
            ClickOnMenu("Languages");

            //2. Click on Languages SubMenu doc-languages
            ClickOnSubMenu("doc-languages", "Languages");
            
            //3. Click on Storage Encoding SubMenu doc-storage_encoding
            ClickOnSubMenu("doc-storage_encoding", "Storage Encoding");

        }

        public void CheckModulesMenu()
        {
            //1. Click on Modules Menu
            ClickOnMenu("Modules", "Job Modules");

            //2. Click on Background Jobs SubMenu doc-jobs
            ClickOnSubMenu("doc-jobs", " Modules");
            
            //3. Click on Customer SubMenu doc-customer
            ClickOnSubMenu("doc-customer", "Customer Modules");
            
            //4. Click on Shipping SubMenu doc-shipping
            ClickOnSubMenu("doc-shipping", "Shipping Modules");
            
            //5. Click on Payment SubMenu doc-payment
            ClickOnSubMenu("doc-payment", "Payment Modules");
            
            //6. Click on Order Total SubMenu  doc-order_total
            ClickOnSubMenu("doc-order_total", "Order Total Modules");
            
            //7. Click on Order Success SubMenu doc-order_success
            ClickOnSubMenu("doc-order_success", "Order Success Modules");
            
            //8. Click on Order Action SubMenu doc-order_action
            ClickOnSubMenu("doc-order_action", "Order Action Modules");
            
        }

        public void CheckOrdersMenu()
        {
            //1. Click on Orders Menu
            ClickOnMenu("Orders");

            //2. Click on Orders SubMenu doc-orders
            ClickOnSubMenu("doc-orders", "Orders");
           
            //3. Click on Order Statuses SubMenu doc-order_statuses
            ClickOnSubMenu("doc-order_statuses", "Order Statuses");
           
        }
        
        public void CheckPagesMenu()
        {
            //1. Click on Pages Menu
            ClickOnMenu("Pages");
            
        }

        public void CheckReportsMenu()
        {
            //1. Click on Reports Menu
            ClickOnMenu("Reports", "Monthly Sales");

            //2. Click on Monthly Sales SubMenu doc-monthly_sales
            ClickOnSubMenu("doc-monthly_sales", "Monthly Sales");
            
            //3. Click on Most Sold Products SubMenu doc-most_sold_products
            ClickOnSubMenu("doc-most_sold_products", "Most Sold Products");
            
            //4. Click on Most Shopping Customers SubMenu doc-most_shopping_customers
            ClickOnSubMenu("doc-most_shopping_customers", "Most Shopping Customers");
            
        }

        public void CheckSettingsMenu()
        {
            //1. Click on Settings Menu
            ClickOnMenu("Settings");

            //2. Click on Store Info SubMenu doc-store_info
            ClickOnSubMenu("doc-store_info", "Settings");
           
            //3. Click on Defaults SubMenu doc-defaults
            ClickOnSubMenu("doc-defaults", "Settings");
            
            //4. Click on General  SubMenu doc-general
            ClickOnSubMenu("doc-general", "Settings");
            
            //5. Click on Listings SubMenu doc-listings
            ClickOnSubMenu("doc-listings", "Settings");
            
            //6. Click on Images SubMenu doc-images
            ClickOnSubMenu("doc-images", "Settings");
            
            //7. Click on Checkout SubMenu doc-checkout
            ClickOnSubMenu("doc-checkout", "Settings");
            
            //8. Click on Advanced SubMenu doc-advanced
            ClickOnSubMenu("doc-advanced", "Settings");
            
            //9. Click on Security SubMenu doc-security 
            ClickOnSubMenu("doc-security", "Settings");
            
        }

        public void CheckSlidesMenu()
        {
            //1. Click on Slides Menu
            ClickOnMenu("Slides");
            
        }

        public void CheckTaxMenu()
        {
            //1. Click on Tax Menu
            ClickOnMenu("Tax", "Tax Classes");

            //2. Click on Tax Classes SubMenu doc-tax_classes
            ClickOnSubMenu("doc-tax_classes", "Tax Classes");
            
            //3. Click on Tax Rates Statuses SubMenu doc-tax_rates
            ClickOnSubMenu("doc-tax_rates", "Tax Rates");
           
        }

        public void CheckTranslationsMenu()
        {
            //1. Click on Translations Menu
            ClickOnMenu("Translations", "Search Translations");

            //2. Click on Search Translations SubMenu doc-search
            ClickOnSubMenu("doc-search", "Search Translations");
            
            //3. Click on Scan Files SubMenu doc-scan
            ClickOnSubMenu("doc-scan", "Scan Files For Translations");
            
            //4. Click on CSV Import/Export SubMenu doc-csv
            ClickOnSubMenu("doc-csv", "CSV Import/Export");
            
        }

        public void CheckUsersMenu()
        {
            //1. Click on Users Menu
            ClickOnMenu("Users");
            
        }

        public void CheckvQmodsMenu()
        {
            //1. Click on vQmods Menu
            ClickOnMenu("vQmods");

            //2. Click on vQmods SubMenu doc-vqmods
            ClickOnSubMenu("doc-vqmods", "vQmods");
            
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
                NUnit.Framework.Assert.IsTrue(title.Text.Equals(Title), "Title: " + Title + " Not Found On Page.");
            
        }

        private void CheckFormGeoZone()
        {
            var GeoZoneForm = Driver.FindElement(By.XPath("//form[@name='form_geo_zone']"));
        }
        
        private bool IsTitleOnPage(string Title)
        {
            var title = Driver.FindElement(By.TagName("h1"));
            return title.Text.Equals(Title);

        }

        private void ClickOnMenu(string MenuName)
        {
            var MenuElement = FindElementInMenu(MenuName);
            if (MenuElement is null) { NUnit.Framework.Assert.Fail(MenuName + " Menu not Exist on Page!!!"); }
            else { MenuElement.Click(); }
            CheckTitle(MenuName);
        }

        private void ClickOnMenu(string MenuName, string TitleName)
        {
            var MenuElement = FindElementInMenu(MenuName);
            if (MenuElement is null) { NUnit.Framework.Assert.Fail(MenuName + " Menu not Exist on Page!!!"); }
            else { MenuElement.Click(); }
            CheckTitle(TitleName);
        }

        private void ClickOnSubMenu(string SubMenuIdElement, string Title)
        {
            Driver.FindElement(By.Id(SubMenuIdElement)).Click();
            CheckTitle(Title);
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

        internal IWebElement FindCountryElementByName(string ContryName)
        {
            int iCountryIndex;
            if (IsTitleOnPage("Geo Zones"))
            { iCountryIndex = 2; }
            else if (IsTitleOnPage("Countries"))
            { iCountryIndex = 4; }
            else
            { iCountryIndex = 0; }

            var Rows = GetCountryesTableCollection();

            foreach (var row in Rows)
            {
                var cell = row.FindElements(By.TagName("td"));
                if (cell[iCountryIndex].Text == ContryName)
                {
                    return cell[iCountryIndex];
                }
            }
            return null;


        }

        internal bool IsCountriesTableSorted()
        {
            List<string> CountyName = new List<string>();
            var Rows = GetCountryesTableCollection();
            foreach (var row in Rows)
            {
                var cell = row.FindElements(By.TagName("td"));
                CountyName.Add(cell[4].Text);
            }

            List<string> CountryNameSorted = CountyName.OrderBy(s => s).ToList();
            if (CountyName.SequenceEqual(CountryNameSorted)) return true;
            else return false;
         }

        internal bool IsZonesTableSorted()
        {
            List<string> CountyName = new List<string>();
            var Rows = GetCountryZonesTableCollection();
            foreach (var row in Rows)
            {
                if( ( row.GetAttribute("class") != "header") )
                { 
                    var cell = row.FindElements(By.TagName("td"));
                    if( cell[0].FindElements(By.TagName("input")).Count() > 0)
                    {
                        CountyName.Add(cell[2].Text);
                    }
                }

            }

            List<string> CountryNameSorted = CountyName.OrderBy(s => s).ToList();
            if (CountyName.SequenceEqual(CountryNameSorted)) return true;
            else return false;

        }

        internal bool IsGeoZonesSortedInEachCountry()
        {
            List<string> CountryName = GetCountriesFromGeoZoneTable();

            foreach (string country in CountryName)
            {
                var CountryElement = FindCountryElementByName(country);
                CountryElement.FindElement(By.TagName("a")).Click();

                CheckFormGeoZone();
                
                if (!(IsZonesInGeoZonesEditMenuSorted())) return false;
                GoBackToGeoZonesPage();
            }
            return true;
            
        }
               
        internal bool IsZonesInGeoZonesEditMenuSorted()
        {
            List<string> ZoneName = new List<string>();
            var Rows = GetCountryZonesTableCollection();
            foreach( var row in Rows)
            {
                if ((row.GetAttribute("class") != "header"))
                {
                    var cell = row.FindElements(By.TagName("td"));
                    if (cell[0].FindElements(By.TagName("input")).Count() > 0)
                    {
                        ZoneName.Add(cell[2].FindElement(By.XPath(".//option[@selected='selected']")).Text);
                    }
                }
            }
            List<string> ZoneNameSorted = ZoneName.OrderBy(s => s).ToList();
            if (ZoneName.SequenceEqual(ZoneNameSorted)) return true;
            else return false;
        }

        internal bool IsCountryZonesSorted()
        {
            List<string> CountyNameWithZone = GetCountriesWithZones();
            foreach (string country in CountyNameWithZone)
            {
                var CountryElement = FindCountryElementByName(country);
                CountryElement.FindElement(By.TagName("a")).Click();
                CheckTitle("Edit Country");
                if (!IsZonesTableSorted())  return false;
                GoBackToCountryesPage();
            }
            return true;
        }

        internal ReadOnlyCollection<IWebElement> GetCountryesTableCollection ()
        {
            var CountriesTable = Driver.FindElement(By.ClassName("dataTable"));
            return CountriesTable.FindElements(By.ClassName("row"));

        }

      /*  internal ReadOnlyCollection<IWebElement> GetGeoZonesTableCollection()
        {
            var GeoZonesTable = Driver.FindElement(By.ClassName("dataTable"));
            return GeoZonesTable.FindElements(By.ClassName("row"));

        }*/

        internal ReadOnlyCollection<IWebElement> GetCountryZonesTableCollection()
        {
            var ZonesTable = Driver.FindElement(By.ClassName("dataTable"));
            return ZonesTable.FindElements(By.TagName("tr"));
        }

        internal List<string> GetCountriesWithZones()
        {
            List<string> CountyNameList = new List<string>();
            var Rows = GetCountryesTableCollection();
            foreach (var row in Rows)
            {
                var cell = row.FindElements(By.TagName("td"));
                int.TryParse(cell[5].Text, out int zones);
                if (zones > 0)
                { CountyNameList.Add(cell[4].Text); }

            }

            return CountyNameList;
        }

        internal List<string> GetCountriesFromGeoZoneTable()
        {
            List<string> CountyNameList = new List<string>();
            var Rows = GetCountryesTableCollection();
            foreach (var row in Rows)
            {
                var cell = row.FindElements(By.TagName("td"));
                CountyNameList.Add(cell[2].Text);
            }

            return CountyNameList;
        }
    
        internal void GoBackToGeoZonesPage()
        {
            Driver.Url = "http://localhost:8080/litecart/admin/?app=geo_zones&doc=geo_zones";
        }

        internal void GoBackToCountryesPage()
        {
            Driver.Url = "http://localhost:8080/litecart/admin/?app=countries&doc=countries";
        }
                
   }
}
