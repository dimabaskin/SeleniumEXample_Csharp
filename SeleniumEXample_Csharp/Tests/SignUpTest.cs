using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumEXample_Csharp.Pages;
using SeleniumEXample_Csharp.Types;

namespace SeleniumEXample_Csharp.Tests
{
    public class SignUpTest : BaseTest
    {
        [Test]
        [TestCase(Category = "LogIn")]
        public void SignUpWithNewRandomUser()
        {
            HomePage mainPage = new HomePage(driver);
            mainPage.ClickOnSignUpButton();
            SignupPage SignUpPage = new SignupPage(driver);
            User NewRandomUser = new User();
            SignUpPage.CreateRandomAccount(NewRandomUser);
            NUnit.Framework.Assert.IsTrue(mainPage.IsUserCreated(), " Error - User creation failed");
            mainPage.LogOut();
            NUnit.Framework.Assert.IsTrue(mainPage.IsUserLogedOut(), " Error - User failed to log out.");
            mainPage.LogIn(NewRandomUser);
            NUnit.Framework.Assert.IsTrue(mainPage.IsUserLogedIn(NewRandomUser), " Error - User failed to log in");
            mainPage.LogOut();
            NUnit.Framework.Assert.IsTrue(mainPage.IsUserLogedOut(), " Error - User failed to log out.");

        }

    }
}
