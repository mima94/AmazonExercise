using AmazonExercise.Pages;
using NUnit.Framework;
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

            CartPage cartPage = new CartPage();

            NavigateTo.Homepage();
            NavigateTo.Search();
            Actions.FillTheSearch("dresses");
            Actions.ClickSearchButton();
            Actions.ClickOnFilters();
            Actions.ClickOnDressOne();
            Actions.ChooseSize();   
            Actions.ClickOnAddToCartButton();

            Assert.AreEqual(cartPage.AddedToCart.Text, "Added to Cart");

            NavigateTo.Homepage();
            NavigateTo.Search();
            Actions.FillTheSearch("dresses");
            Actions.ClickSearchButton();
            Actions.ClickOnFilters();
            Actions.ClickOnDressTwo();
            Actions.ChooseSize();
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
