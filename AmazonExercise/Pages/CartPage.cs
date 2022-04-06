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


        [FindsBy(How = How.CssSelector, Using = "#sc-item-C0a88d343-29b2-47d3-bec1-bd15555f494a > div.sc-list-item-content > div > div.a-column.a-span10 > div > div > div.a-fixed-left-grid-col.a-col-right > div.a-row.sc-action-links > span.a-size-small.sc-action-delete")]
        public IWebElement DeleteItem { get; set; }
    }
}
