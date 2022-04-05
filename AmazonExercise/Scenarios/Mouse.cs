using AmazonExercise.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmazonExercise.Scenarios
{
    public class Mouse
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
        public void SearchForMouse()
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            CartPage cartPage = new CartPage();

            NavigateTo.Homepage();
            NavigateTo.Search();
            Actions.FillTheSearch("mouse");
            Actions.ClickSearchButton();
            Actions.ClickOnMouse();
            Actions.ClickOnAddToCartButton();

            Assert.AreEqual(cartPage.AddedToCart.Text, "Added to Cart");


            if (cartPage.SecondCartButton.Displayed)
            {
                NavigateTo.CartThruTheProduct();
            }
            else
            {
                NavigateTo.CartThruTheMenu();
            }

        }

        [OneTimeTearDown]

        public void TearDown()
        {
            Driver.driver.Quit();
        }
    }
}
