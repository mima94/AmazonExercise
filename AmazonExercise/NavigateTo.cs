using AmazonExercise.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonExercise
{
    public static  class NavigateTo
    {
        public static void Homepage()
        {
            Driver.driver.Navigate().GoToUrl(Configuration.BaseURL);
        }

        public static void Search()
        {
            MenuElements menuElements = new MenuElements();

            menuElements.SearchBox.Click();
        }

        public static void CartThruTheMenu()
        {
            MenuElements menuElements = new MenuElements();

            menuElements.Cart.Click();
        }

        public static void CartThruTheProduct()
        {
            CartPage cartPage = new CartPage();

            cartPage.SecondCartButton.Click();
        }

        public static void SignInPage()
        {
            MenuElements menuElements = new MenuElements();

            menuElements.SignInButton.Click();
        }
    }
}
