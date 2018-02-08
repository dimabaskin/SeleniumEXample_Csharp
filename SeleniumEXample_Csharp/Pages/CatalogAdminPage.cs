using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumEXample_Csharp.Types;
using SeleniumEXample_Csharp.Utils;



namespace SeleniumEXample_Csharp.Pages
{
    public class CatalogAdminPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = @"//a[@class='button'][contains(.,'Add New Product')]")]
        private IWebElement _addNewProductButton { get; set; }
        [FindsBy(How = How.XPath, Using = @"//a[@href='#tab-general']")]
        private IWebElement _ProductGeneralTabLink { get; set; }
        [FindsBy(How = How.XPath, Using = @"//a[@href='#tab-information']")]
        private IWebElement _ProductInformationTabLink { get; set; }
        [FindsBy(How = How.XPath, Using = @"//a[@href='#tab-prices']")]
        private IWebElement _ProductPricesTabLink { get; set; }
        [FindsBy(How = How.XPath, Using = @"//label[contains(text(),'Enabled')]//input[@name='status']")]
        private IWebElement _GeneralStatusEnableRadio { get; set; }
        [FindsBy(How = How.XPath, Using = @"//label[contains(text(),'Disabled')]//input[@name='status']")]
        private IWebElement _GeneralStatusDisableRadio { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='name[en]']")]
        private IWebElement _GeneralProductName { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='code']")]
        private IWebElement _GeneralProductCode { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='categories[]'][@data-name='Root'][@type='checkbox']")]
        private IWebElement _GeneralCategoriesRootCheckBox { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='categories[]'][@data-name='Rubber Ducks'][@type='checkbox']")]
        private IWebElement _GeneralCategoriesRubberDucksCheckBox { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='categories[]'][@data-name='Subcategory'][@type='checkbox']")]
        private IWebElement _GeneralCategoriesSubcategoryCheckBox { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='quantity']")]
        private IWebElement _GeneralQuantity { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='new_images[]'][@type='file']")]
        private IWebElement _BrowseFileButton { get; set; }
        [FindsBy(How = How.XPath, Using = @"//select[@name='manufacturer_id']")]
        private IWebElement _InformationManufacturerDropDownList { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='keywords']")]
        private IWebElement _InformationKeywords { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='short_description[en]']")]
        private IWebElement _InformationShortDescription { get; set; }
        [FindsBy(How = How.XPath, Using = @"//div[@class='trumbowyg-editor']")]
        private IWebElement _InformationProductDescription { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='head_title[en]']")]
        private IWebElement _InformationProductHeadTitle { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name='purchase_price']")]
        private IWebElement _PricesPurchasePrice { get; set; }
        [FindsBy(How = How.XPath, Using = @"//select[@name='purchase_price_currency_code']")]
        private IWebElement _PricesPurchasePriceCurrency { get; set; }
        [FindsBy(How = How.XPath, Using = @"//button[@name='save'][@type='submit']")]
        private IWebElement _SaveButton { get; set; }
        [FindsBy(How = How.XPath, Using = @"//button[@name='cancel'][@type='submit']")]
        private IWebElement _CancelButton { get; set; }
        [FindsBy(How = How.XPath, Using = @"//button[@name='delete'][@type='submit']")]
        private IWebElement _DeleteButton { get; set; }

        private readonly By _ProductGeneralTabLocator;
        private readonly By _ProductInformationTabLocator;
        private readonly By _ProductPricesTabLocator;
        private readonly By _CatalogFormLocator;

        [FindsBy(How = How.XPath, Using = @"//table[@class='dataTable']//tr[@class='row']")]
        private IList<IWebElement> _AllProductsList { get; set; }
        [FindsBy(How = How.XPath, Using = @"//td/input[@name='product_groups[]']")]
        private IList<IWebElement> _GeneralProductGroupsCheckBoxes { get; set; }

        private IWebElement _GeneralProductGroupsFemaleCheckBox { get; set; }
        private IWebElement _GeneralProductGroupsMaleCheckBox { get; set; }
        private IWebElement _GeneralProductGroupsUnisexCheckBox { get; set; }


        public AdminCatalogProduct NewProduct;

        public CatalogAdminPage(IWebDriver Driver) : base(Driver)
        {
            _ProductGeneralTabLocator = By.Id("tab-general");
            _ProductInformationTabLocator = By.Id("tab-information");
            _ProductPricesTabLocator = By.Id("tab-prices");
            _CatalogFormLocator = By.Name("catalog_form");

            //_addNewProductButton = Driver.FindElement(By.XPath("//a[@class='button'][contains(.,'Add New Product')]"));
            //_ProductGeneralTabLink = Driver.FindElement(By.XPath("//a[@href='#tab-general']"));
            //_ProductInformationTabLink = Driver.FindElement(By.XPath("//a[@href='#tab-information']"));
            //_ProductPricesTabLink = Driver.FindElement(By.XPath("//a[@href='#tab-prices']"));
            //_AllProductsList = Driver.FindElements(By.XPath("//table[@class='dataTable']//tr[@class='row']"));
            //_GeneralStatusEnableRadio = Driver.FindElement(By.XPath("//input[@name='status'][contains(.,'Enabled')]"));
            //_GeneralStatusDisableRadio = Driver.FindElement(By.XPath("//input[@name='status'][contains(.,'Disabled')]"));
            //_GeneralProductName = Driver.FindElement(By.XPath("//input[@name='name[en]']"));
            //_GeneralProductCode = Driver.FindElement(By.XPath("//input[@name='code']"));
            // _GeneralCategoriesRootCheckBox = Driver.FindElement(By.XPath("//input[@name='categories[]'][@data-name='Root'][@type='checkbox']"));
            // _GeneralCategoriesRubberDucksCheckBox = Driver.FindElement(By.XPath("//input[@name='categories[]'][@data-name='Rubber Ducks'][@type='checkbox']"));
            //_GeneralCategoriesSubcategoryCheckBox = Driver.FindElement(By.XPath("//input[@name='categories[]'][@data-name='Subcategory'][@type='checkbox']"));
            // _GeneralProductGroupsCheckBoxes = Driver.FindElements(By.XPath("//td/input[@name='product_groups[]']"));
            // _GeneralProductGroupsFemaleCheckBox = _GeneralProductGroupsCheckBoxes[0];
            // _GeneralProductGroupsMaleCheckBox = _GeneralProductGroupsCheckBoxes[1];
            // _GeneralProductGroupsUnisexCheckBox = _GeneralProductGroupsCheckBoxes[2];
            // _GeneralQuantity = Driver.FindElement(By.XPath("//input[@name='quantity']"));
            //  _BrowseFileButton = Driver.FindElement(By.XPath("//input[@name='new_images[]'][@type='file']"));
            //  _InformationManufacturerDropDownList = Driver.FindElement(By.XPath("//select[@name='manufacturer_id']"));
            //  _InformationKeywords = Driver.FindElement(By.XPath("//input[@name='keywords']"));
            //  _InformationShortDescription = Driver.FindElement(By.XPath("//input[@name='short_description[en]']"));
            //  _InformationProductDescription = Driver.FindElement(By.XPath("//div[@class='trumbowyg-editor']"));
            //  _InformationProductHeadTitle = Driver.FindElement(By.XPath("//input[@name='head_title[en]']"));
            //  _PricesPurchasePrice = Driver.FindElement(By.XPath("//input[@name='purchase_price']"));
            //  _PricesPurchasePriceCurrency = Driver.FindElement(By.XPath("//select[@name='purchase_price_currency_code']"));
            //   _SaveButton = Driver.FindElement(By.XPath("//button[@name='save'][@type='submit']"));
            //   _CancelButton = Driver.FindElement(By.XPath("//button[@name='cancel'][@type='submit']"));
            //   _DeleteButton = Driver.FindElement(By.XPath("//button[@name='delete'][@type='submit']"));

            NewProduct = new AdminCatalogProduct();


        }

        public CatalogAdminPage ClickAddNewProductButton()
        {
            NewProduct.CreateRandomProductData();
            _addNewProductButton.Click();
            return this;
        }

        public CatalogAdminPage FillGeneralTabProductData()
        {
            _ProductGeneralTabLink.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(_ProductGeneralTabLocator));

            //_GeneralProductGroupsCheckBoxes = Driver.FindElements(By.XPath("//td/input[@name='product_groups[]']"));
            _GeneralProductGroupsFemaleCheckBox = _GeneralProductGroupsCheckBoxes[0];
            _GeneralProductGroupsMaleCheckBox = _GeneralProductGroupsCheckBoxes[1];
            _GeneralProductGroupsUnisexCheckBox = _GeneralProductGroupsCheckBoxes[2];

            if (NewProduct._SatusEnabled) { _GeneralStatusEnableRadio.Click(); }
            else { _GeneralStatusDisableRadio.Click(); }
            _GeneralProductName.Clear();
            _GeneralProductName.SendKeys(NewProduct._ProductName);
            _GeneralProductCode.Clear();
            _GeneralProductCode.SendKeys(NewProduct._ProductCode);

            //Select Root OR Rubber Duck OR SubCategory
            if (NewProduct._ProductCategory == "Rubber Ducks")
            {
                SelectGeneralRubberDucksCategoryChekBox();
            }
            else if(NewProduct._ProductCategory == "Subcategory")
            {
                SelectGeneralSubcategoryCategoryChekBox();
            }
            else
            {
                SelectGeneralRootCategoryChekBox();
            }
            
            //Select Female Male OR Unisex
            if (NewProduct._ProductGroupGender == "Female")
            {
                SelectGenderFemaleCheckBox();
            }
            else if(NewProduct._ProductGroupGender == "Male")
            {
                SelectGenderMaleCheckBox();
            }
            else
            {
                SelectGenderUnisexCheckBox();
            }

            _GeneralQuantity.Clear();
            _GeneralQuantity.SendKeys(NewProduct._ProductQuantity);

            UploadProductImage();


            return this;
        }

        public CatalogAdminPage FillInformationTabProductData()
        {
            _ProductInformationTabLink.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(_ProductInformationTabLocator));

            var Manufacturer = new SelectElement(_InformationManufacturerDropDownList);
            Manufacturer.SelectByText(NewProduct._ProductManufacturer);
            _InformationKeywords.Clear();
            _InformationKeywords.SendKeys(NewProduct._ProductKeyWords);
            _InformationShortDescription.Clear();
            _InformationShortDescription.SendKeys(NewProduct._ProductShortDescription);
            _InformationProductHeadTitle.Clear();
            _InformationProductHeadTitle.SendKeys(NewProduct._ProductHeadTitle);

            
            _InformationProductDescription.Clear();
               for (int i=0; i < 5; i++)
               {
                   _InformationProductDescription.Clear();
                   _InformationProductDescription.SendKeys(" TEST " + i.ToString() );
                   System.Threading.Thread.Sleep(1000);
               }

            _InformationProductDescription.Clear();
            _InformationProductDescription.SendKeys(NewProduct._ProductInformationDescription);
            
            return this;
        }

        public CatalogAdminPage FillPricesTabProductData()
        {
            _ProductPricesTabLink.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(_ProductPricesTabLocator));

            _PricesPurchasePrice.Clear();
            _PricesPurchasePrice.SendKeys(NewProduct._ProductPurchasePrice);
            var Currency = new SelectElement(_PricesPurchasePriceCurrency);
            Currency.SelectByValue(NewProduct._ProductPurchasePriceCurrency);

            return this;
        }

        public CatalogAdminPage SaveNewProduct()
        {
            _SaveButton.Click();
            return this;
        }

        public bool CheckIfProductWasAddedToCatalog()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(_CatalogFormLocator));
            //_AllProductsList = Driver.FindElements(By.XPath("//table[@class='dataTable']//tr[@class='row']"));

            foreach (var row in _AllProductsList)
            {
                if (row.Text.Contains(NewProduct._ProductName))
                { return true; }
            }
            return false;
        }

        private void UploadProductImage()
        {
            new WebDriverUtils().Unhide(Driver, _BrowseFileButton);
            _BrowseFileButton.SendKeys(NewProduct._ProductImagePath.ToString());
            //TO DO Check how to Set File Path to The 
        }

        private void SelectGenderUnisexCheckBox()
        {
            if(_GeneralProductGroupsFemaleCheckBox.Selected)
            {
                _GeneralProductGroupsFemaleCheckBox.Click();
            }
            if(_GeneralProductGroupsMaleCheckBox.Selected)
            {
                _GeneralProductGroupsMaleCheckBox.Click();
            }
            if(!_GeneralProductGroupsUnisexCheckBox.Selected)
            {
                _GeneralProductGroupsUnisexCheckBox.Click();
            }
        }

        private void SelectGenderMaleCheckBox()
        {
            if (_GeneralProductGroupsFemaleCheckBox.Selected)
            {
                _GeneralProductGroupsFemaleCheckBox.Click();
            }
            if (!_GeneralProductGroupsMaleCheckBox.Selected)
            {
                _GeneralProductGroupsMaleCheckBox.Click();
            }
            if (_GeneralProductGroupsUnisexCheckBox.Selected)
            {
                _GeneralProductGroupsUnisexCheckBox.Click();
            }
        }

        private void SelectGenderFemaleCheckBox()
        {
            if (!_GeneralProductGroupsFemaleCheckBox.Selected)
            {
                _GeneralProductGroupsFemaleCheckBox.Click();
            }
            if (_GeneralProductGroupsMaleCheckBox.Selected)
            {
                _GeneralProductGroupsMaleCheckBox.Click();
            }
            if (_GeneralProductGroupsUnisexCheckBox.Selected)
            {
                _GeneralProductGroupsUnisexCheckBox.Click();
            }
        }

        

        private void SelectGeneralRootCategoryChekBox()
        {
            if (!_GeneralCategoriesRootCheckBox.Selected)
            {
                _GeneralCategoriesRootCheckBox.Click();
            }
            if (_GeneralCategoriesRubberDucksCheckBox.Selected)
            {
                _GeneralCategoriesRubberDucksCheckBox.Click();
            }
            if(_GeneralCategoriesSubcategoryCheckBox.Selected)
            {
                _GeneralCategoriesSubcategoryCheckBox.Click();
            }
        }

        private void SelectGeneralRubberDucksCategoryChekBox()
        {
            if (_GeneralCategoriesRootCheckBox.Selected)
            {
                _GeneralCategoriesRootCheckBox.Click();
            }
            if (!_GeneralCategoriesRubberDucksCheckBox.Selected)
            {
                _GeneralCategoriesRubberDucksCheckBox.Click();
            }
            if (_GeneralCategoriesSubcategoryCheckBox.Selected)
            {
                _GeneralCategoriesSubcategoryCheckBox.Click();
            }
        }

        private void SelectGeneralSubcategoryCategoryChekBox()
        {
            if (_GeneralCategoriesRootCheckBox.Selected)
            {
                _GeneralCategoriesRootCheckBox.Click();
            }
            if (_GeneralCategoriesRubberDucksCheckBox.Selected)
            {
                _GeneralCategoriesRubberDucksCheckBox.Click();
            }
            if (!_GeneralCategoriesSubcategoryCheckBox.Selected)
            {
                _GeneralCategoriesSubcategoryCheckBox.Click();
            }
        }
    }
}
