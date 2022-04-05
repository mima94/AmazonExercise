using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonExercise.Pages
{
    public class ProductPage
    {
        public ProductPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#search > div.s-desktop-width-max.s-desktop-content.s-opposite-dir.sg-row > div.s-matching-dir.sg-col-16-of-20.sg-col.sg-col-8-of-12.sg-col-12-of-16 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div:nth-child(2) > div > div > div > div > div > div > div > div.sg-col.sg-col-4-of-12.sg-col-4-of-16.sg-col-4-of-20.s-list-col-left > div > div.s-product-image-container.aok-relative.s-image-overlay-grey.s-text-center.s-padding-left-small.s-padding-right-small.s-flex-expand-height > div > span > a > div")]
        public IWebElement FirstMouse { get; set; }

        [FindsBy(How = How.Id, Using = "submit.add-to-cart")]
        public IWebElement AddToCartButton { get; set; }

        [FindsBy(How = How.Id, Using = "buy-now-button")]
        public IWebElement ByNowButton { get; set; }

        [FindsBy(How = How.Id, Using = "n/2346727011")]
        public IWebElement FilterOne { get; set; }

        [FindsBy(How = How.Id, Using = "p_89/Calvin Klein")]
        public IWebElement FilterTwo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search > div.s-desktop-width-max.s-desktop-content.s-opposite-dir.sg-row > div.s-matching-dir.sg-col-16-of-20.sg-col.sg-col-8-of-12.sg-col-12-of-16 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div:nth-child(2)")]
        public IWebElement DressOne { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search > div.s-desktop-width-max.s-desktop-content.s-opposite-dir.sg-row > div.s-matching-dir.sg-col-16-of-20.sg-col.sg-col-8-of-12.sg-col-12-of-16 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div:nth-child(3)")]
        public IWebElement DressTwo { get; set; }

        [FindsBy(How = How.Id, Using = "dropdown_selected_size_name")]
        public IWebElement SelectSizeButton { get; set; }

        [FindsBy(How = How.Id, Using = "size_name_1")]
        public IWebElement SelectSizeNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search > div.s-desktop-width-max.s-desktop-content.s-opposite-dir.sg-row > div.s-matching-dir.sg-col-16-of-20.sg-col.sg-col-8-of-12.sg-col-12-of-16 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div:nth-child(2) > div > div > div > div > div > div.sg-col.sg-col-4-of-12.sg-col-4-of-16.sg-col-4-of-20.s-list-col-left > div > div.s-product-image-container.aok-relative.s-image-overlay-grey.s-text-center.s-padding-left-small.s-padding-right-small.s-flex-expand-height > div > span > a > div")]
        public IWebElement HarryPotterBook { get; set; }
    }
}
