using AmazonExercise.Pages;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmazonExercise.Scenarios
{
    public class DeletingDress
    {

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();

        }

        [Test, Order(1)]
        public void SignIn()
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            NavigateTo.Homepage();
            NavigateTo.SignInPage();
            Actions.FillSignInForm();
        }

        [Test, Order(2)]

        public void SearchForDresses()
        {
            Driver.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));


            CartPage cartPage = new CartPage();
            ProductPage productPage = new ProductPage();

            NavigateTo.Homepage();
            NavigateTo.Search();
            Actions.FillTheSearch("dresses");
            Actions.ClickSearchButton();
            Actions.ClickOnDressOne();
            Actions.ChooseSize();
            Thread.Sleep(4000);
            Actions.ClickOnAddToCartButton();


            Assert.AreEqual(cartPage.AddedToCart.Text, "Added to Cart");

            NavigateTo.Homepage();
            NavigateTo.Search();
            Actions.FillTheSearch("dresses");
            Actions.ClickSearchButton();
            Actions.ClickOnDressTwo();
            Actions.ChooseSize();
            //wait.Until(ExpectedConditions.ElementToBeClickable(productPage.AddToCartButton));
            //wait.Until(ExpectedConditions.ElementIsVisible((By)productPage.ByNowButton));
            Thread.Sleep(4000);
            Actions.ClickOnAddToCartButton();

            Assert.AreEqual(cartPage.AddedToCart.Text, "Added to Cart");

            NavigateTo.CartThruTheMenu();
            Actions.DeleteItem();


        }

        [OneTimeTearDown]

        public void TearDown()
        {
            Driver.driver.Quit();
        }
    }
}
