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
                  TestName ="Check All Admin Menu")]
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
                  TestName = "Click on All Admin Menu")]
        public void ClickAllAdminMenu()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.ClickOnAllMenus();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Appearence Admin Menu")]
        public void AppearenceMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckAppearenceMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Catalog Admin Menu")]
        public void CatalogMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCatalogMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Countries Admin Menu")]
        public void CountriesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCountriesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Currencies Admin Menu")]
        public void CurrenciesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCurrenciesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Customers Admin Menu")]
        public void CustomersMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCustomersMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check GeoZones Admin Menu")]
        public void GeoZonesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckGeoZonesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Languages Admin Menu")]
        public void LanguagesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckLanguagesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Modules Admin Menu")]
        public void ModulesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckModulesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Orders Admin Menu")]
        public void OrdersMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckOrdersMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Pages Admin Menu")]
        public void PagesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckPagesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Reports Admin Menu")]
        public void ReportsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckReportsMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Settings Admin Menu")]
        public void SettingsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckSettingsMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Slides Admin Menu")]
        public void SlidesMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckSlidesMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Tax Admin Menu")]
        public void TaxMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckTaxMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Translations Admin Menu")]
        public void TranslationsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckTranslationsMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Check Users Admin Menu")]
        public void UsersMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckUsersMenu();
        }

        [Test]
        [TestCase(Category = "Admin",
                TestName = "Check VQmods Admin Menu") ]
        public void VQmodsMenuTest()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckvQmodsMenu();
        }

        [Test]
        [TestCase(Category ="Admin",
                  TestName = "Countries Are Sorted in Countries Menu")]
        public void CountriesAreSortedInCountriesMenu()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.CheckCountriesMenu();
            NUnit.Framework.Assert.IsTrue(AdminPage.IsCountriesTableSorted(), "Error - Countries Table not Sorted .");
            NUnit.Framework.Assert.IsTrue(AdminPage.IsCountryZonesSorted(), "Error - Country Zone Table not sorted . ");
        }

        [Test]
        [TestCase(Category = "Admin",
                  TestName = "Countries Are Sorted in Geo Zone Menu")]
        public void CountriesAreSortedInGeoZoneMenu()
        {
            MainAdminPage AdminPage = new MainAdminPage(driver);
            AdminPage.GoBackToGeoZonesPage();
            NUnit.Framework.Assert.IsTrue(AdminPage.IsGeoZonesSortedInEachCountry(), "Error - Geo Zone not Sorted");

            
        }

    }
}
