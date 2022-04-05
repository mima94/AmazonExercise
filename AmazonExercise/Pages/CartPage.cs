using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonExercise.Pages
{
    public  class CartPage
    {
        public CartPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#sw-gtc > span > a")]
        public IWebElement SecondCartButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#sw-atc-details-single-container > div.a-section.a-padding-medium.sw-atc-message-section > div > span")]
        public IWebElement AddedToCart { get; set; }


        [FindsBy(How = How.Name, Using = "submit.delete.Ca3c1130f-1d60-44a6-8193-0cd29e1bc023")]
        public IWebElement DeleteItem { get; set; }
    }
}
