using AmazonExercise.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmazonExercise
{
    public class Dress
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
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));

            CartPage cartPage = new CartPage();
            ProductPage productPage = new ProductPage();

            NavigateTo.Homepage();
            NavigateTo.Search();
            Actions.FillTheSearch("dresses");
            Actions.ClickSearchButton();
            Actions.ClickOnFilters();
            Actions.ClickOnDressOne();
            Actions.ChooseSize();
            Thread.Sleep(4000);
            //wait.Until(ExpectedConditions.ElementToBeClickable(productPage.AddToCartButton));
            Actions.ClickOnAddToCartButton();

            Assert.AreEqual(cartPage.AddedToCart.Text, "Added to Cart");

            NavigateTo.Homepage();
            NavigateTo.Search();
            Actions.FillTheSearch("dresses");
            Actions.ClickSearchButton();
            Actions.ClickOnFilters();
            Actions.ClickOnDressTwo();
            Actions.ChooseSize();
            //wait.Until(ExpectedConditions.ElementToBeClickable(productPage.AddToCartButton));
            Thread.Sleep(4000);
            Actions.ClickOnAddToCartButton();

            Assert.AreEqual(cartPage.AddedToCart.Text, "Added to Cart");


        }

        [OneTimeTearDown]

        public void TearDown()
        {
            Driver.driver.Quit();
        }
    }

}
