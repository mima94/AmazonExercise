using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonExercise.Pages
{
    public  class SignInPage
    {
        public SignInPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement ContinueButton { get; set; }


        [FindsBy(How = How.Id, Using = "ap_email")]
        public IWebElement UsernameField { get; set; }


        [FindsBy(How = How.Id, Using = "ap_password")]
        public IWebElement PasswordField { get; set; }


        [FindsBy(How = How.Id, Using = "signInSubmit")]
        public IWebElement SignInSubmitButton { get; set; }
    }
}
