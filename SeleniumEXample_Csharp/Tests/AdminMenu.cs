using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using SeleniumEXample_Csharp.Pages;
using NUnit.Framework;

namespace SeleniumEXample_Csharp.Tests
{
    public class AdminMenu : BaseTest
    {
        [Test]
        [TestCase(Category = "Admin",
                  TestName ="Check All Admin Menu",
                  Description ="Test check all Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void CheckAllAdminMenu()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckAppearenceMenu();
            AdminPage.CheckCatalogMenu();
            AdminPage.CheckCountriesMenu();
            AdminPage.CheckCurrenciesMenu();
            AdminPage.CheckCustomersMenu();
            AdminPage.CheckGeoZonesMenu();
            AdminPage.CheckLanguagesMenu();
            AdminPage.CheckModulesMenu();
            AdminPage.CheckOrdersMenu();
            AdminPage.CheckPagesMenu();
            AdminPage.CheckReportsMenu();
            AdminPage.CheckSettingsMenu();
            AdminPage.CheckSlidesMenu();
            AdminPage.CheckTaxMenu();
            AdminPage.CheckTranslationsMenu();
            AdminPage.CheckUsersMenu();
            AdminPage.CheckvQmodsMenu();

        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Click on All Admin Menu",
                  Description = "Test check thet all Admin Menu and Submenu are clickable , clicking on each and verify page have header <h1>.")]
        public void ClickAllAdminMenu()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.ClickOnAllMenus();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Appearence Admin Menu",
                  Description = "Test check Appearence Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void AppearenceMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckAppearenceMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Catalog Admin Menu",
                  Description = "Test check Catalog Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void CatalogMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCatalogMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Countries Admin Menu",
                  Description = "Test check Countries Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void CountriesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCountriesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Currencies Admin Menu",
                  Description = "Test check Currencies Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void CurrenciesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCurrenciesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Customers Admin Menu",
                  Description = "Test check Customers Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void CustomersMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCustomersMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check GeoZones Admin Menu",
                  Description = "Test check GeoZones Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void GeoZonesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckGeoZonesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Languages Admin Menu",
                  Description = "Test check Languages Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void LanguagesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckLanguagesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Modules Admin Menu",
                  Description = "Test check Modules Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void ModulesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckModulesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Orders Admin Menu",
                  Description = "Test check Orders Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void OrdersMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckOrdersMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Pages Admin Menu",
                  Description = "Test check Pages Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void PagesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckPagesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Reports Admin Menu",
                  Description = "Test check Reports Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void ReportsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckReportsMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Settings Admin Menu",
                  Description = "Test check Settings Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void SettingsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckSettingsMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Slides Admin Menu",
                  Description = "Test check Slides Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void SlidesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckSlidesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Tax Admin Menu",
                  Description = "Test check Tax Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void TaxMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckTaxMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Translations Admin Menu",
                  Description = "Test check Translations Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void TranslationsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckTranslationsMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Users Admin Menu",
                  Description = "Test check Users Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void UsersMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckUsersMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check VQmods Admin Menu",
                  Description = "Test check VQmods Admin Menu and Submenu by clicking on it and verify user get the rigth page.")]
        public void VQmodsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckvQmodsMenu();
        }



    }
}
