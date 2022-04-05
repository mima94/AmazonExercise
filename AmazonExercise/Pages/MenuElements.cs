using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonExercise.Pages
{
    public class MenuElements
    {
        public MenuElements()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "nav-logo-sprites")]
        public IWebElement HomePageLogo { get; set; }


        [FindsBy(How = How.Id, Using = "nav-search-dropdown-card")]
        public IWebElement AllDropDownList { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#searchDropdownBox > option:nth-child(6)")]
        public IWebElement Books { get; set; }


        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement SearchBox { get; set; }


        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        public IWebElement SearchButton { get; set; }


        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        public IWebElement SignInButton { get; set; }


        [FindsBy(How = How.Id, Using = "nav-cart")]
        public IWebElement Cart { get; set; }
    }
}
