using AmazonExercise.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Firefox;

namespace AmazonExercise
{
    public static  class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
        }

        public static void FillTheSearch(string text)
        {
            MenuElements menuElements = new MenuElements();

            menuElements.SearchBox.SendKeys(text);

        }

        public static void ClickSearchButton()
        {
            MenuElements menuElements = new MenuElements();

            menuElements.SearchButton.Click();
        }

        public static void ClickOnMouse()
        {
            ProductPage productPage = new ProductPage();

            productPage.FirstMouse.Click();
        }

        public static void ClickOnAddToCartButton()
        {
            ProductPage productPage = new ProductPage();

            productPage.AddToCartButton.Click();
        }

        public static void FillSignInForm()
        {
            SignInPage signInPage = new SignInPage();

            signInPage.UsernameField.SendKeys(Configuration.Username);
            signInPage.ContinueButton.Click();
            signInPage.PasswordField.SendKeys(Configuration.Password);
            signInPage.SignInSubmitButton.Click();
        }

        public static void ClickOnFilters()
        {
            ProductPage productsPage = new ProductPage();

            productsPage.FilterOne.Click();
            productsPage.FilterTwo.Click();
        }

        public static void ClickOnDressOne()
        {
            ProductPage productsPage = new ProductPage();

            productsPage.DressOne.Click();
        }

        public static void ClickOnDressTwo()
        {
            ProductPage productsPage = new ProductPage();

            productsPage.DressTwo.Click();
        }

        public static void ChooseSize()
        {
            ProductPage productPage = new ProductPage();

            ProductPage productsPage = new ProductPage();
            productsPage.SelectSizeButton.Click();
            productsPage.SelectSizeNumber.Click();
        }

        public static void FilterBooks()
        {
            MenuElements menuElements = new MenuElements();

            menuElements.AllDropDownList.Click();
            menuElements.Books.Click();
        }

        public static void ClickHarryPotterBook()
        {
            ProductPage productPage = new ProductPage();

            productPage.HarryPotterBook.Click();
        }


        public static void DeleteItem()
        {
            CartPage cartPage = new CartPage();

            cartPage.DeleteItem.Click();
        }

    }
}
