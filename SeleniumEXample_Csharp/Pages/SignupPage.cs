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
    public class SignupPage : BasePage
    {

        private readonly IWebElement _firstNameField;
        private readonly IWebElement _lastNameField;
        private readonly IWebElement _emailField;
        private readonly IWebElement _passwordField;
        private readonly IWebElement _confirmPasswordField;
        private readonly IWebElement _creatAccountButton;
        private readonly IWebElement _address1Field;
        private readonly IWebElement _postcodeField;
        private readonly IWebElement _cityField;
        private readonly IWebElement _countryDropDownField;
        private readonly IWebElement _zonedropDownField;
        private readonly IWebElement _phoneNumberField;

        public SignupPage(IWebDriver driver) : base(driver)
        {
            _firstNameField = driver.FindElement(By.Name("firstname"));
            _lastNameField = driver.FindElement(By.Name("lastname"));
            _address1Field = driver.FindElement(By.Name("address1"));
            _postcodeField = driver.FindElement(By.Name("postcode"));
            _cityField = driver.FindElement(By.Name("city"));
            _countryDropDownField = driver.FindElement(By.XPath("//select[@name='country_code']"));
            _emailField = driver.FindElement(By.Name("email"));
            _phoneNumberField = driver.FindElement(By.Name("phone"));
            _zonedropDownField = driver.FindElement(By.XPath("//select[@name='zone_code']"));
            _passwordField = driver.FindElement(By.Name("password"));
            _confirmPasswordField = driver.FindElement(By.Name("confirmed_password"));
            _creatAccountButton = driver.FindElement(By.Name("create_account"));

        }

        public void CreateRandomAccount(User NewUser)
        {
            _firstNameField.SendKeys(NewUser.FirstName);
            _lastNameField.SendKeys(NewUser.LastName);
            _address1Field.SendKeys(NewUser.Address);
            _postcodeField.SendKeys(NewUser.PostCode);
            _cityField.SendKeys(NewUser.City);
            var selectContryElement = new SelectElement(_countryDropDownField);
            selectContryElement.SelectByText(NewUser.Country);
            var selectZoneElement = new SelectElement(_zonedropDownField);
            if ( IsActiveElement(_zonedropDownField))
            {
                selectZoneElement.SelectByText(NewUser.Zone);
            }
            _emailField.SendKeys(NewUser.Email);
            _phoneNumberField.SendKeys(NewUser.PhoneNumber);
            _passwordField.SendKeys(NewUser.Password);
            _confirmPasswordField.SendKeys(NewUser.Password);
            _creatAccountButton.Click();

        }

        internal bool IsActiveElement(IWebElement element)
        {
            if (element.GetProperty("disabled") == "disabled")
                return false;
            else
                return true;
        }
    }
}
