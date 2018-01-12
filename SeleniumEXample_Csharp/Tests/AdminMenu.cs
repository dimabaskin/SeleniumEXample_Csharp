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
        public void ClickAllAdminMenu()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.ClickOnAllMenus();
        }

        [Test]
        public void AppearenceMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckAppearenceMenu();
        }

        [Test]
        public void CatalogMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCatalogMenu();
        }

        [Test]
        public void CountriesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCountriesMenu();
        }

        [Test]
        public void CurrenciesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCurrenciesMenu();
        }

        [Test]
        public void CustomersMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCustomersMenu();
        }

        [Test]
        public void GeoZonesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckGeoZonesMenu();
        }

        [Test]
        public void LanguagesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckLanguagesMenu();
        }

        [Test]
        public void ModulesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckModulesMenu();
        }

        [Test]
        public void OrdersMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckOrdersMenu();
        }

        [Test]
        public void PagesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckPagesMenu();
        }

        [Test]
        public void ReportsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckReportsMenu();
        }

        [Test]
        public void SettingsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckSettingsMenu();
        }

        [Test]
        public void SlidesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckSlidesMenu();
        }

        [Test]
        public void TaxMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckTaxMenu();
        }

        [Test]
        public void TranslationsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckTranslationsMenu();
        }

        [Test]
        public void UsersMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckUsersMenu();
        }

        [Test]
        public void vQmodsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckvQmodsMenu();
        }



    }
}
