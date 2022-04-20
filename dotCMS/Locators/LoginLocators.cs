using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotCMS.Locators
{
    public class LoginLocators
    {
        public By loginLogoLocator
        {
            get
            {
                return By.ClassName("login__logo");
            }
        }

        //public By emailInput
        //{
        //    get
        //    {
        //        return By.Id("inputtext");
        //    }
        //}

        //public By passwordInput
        //{
        //    get
        //    {
        //        return By.XPath("//*[contains(@data-testid,'password')]");
        //    }
        //}

        //public By signInButton
        //{
        //    get
        //    {
        //        return By.XPath("//*[contains(@data-testid,'submitButton')]");
        //    }
        //}

        public String loginLogo
        {
            get
            {
                return "login__logo";
            }
        }

        public String emailInput
        {
            get
            {
                return "inputtext";
            }
        }

        public String passwordInput
        {
            get
            {
                //return "//input[contains(@type,'password')]";
                return "p-inputtext";
            }
        }

        public String signInButton
        {
            get
            {
                return "//*[contains(@data-testid,'submitButton')]";
            }
        }

        public String LogoutIcon //id
        {
            get
            {
                return "dot-toolbar-user";
            }
        }

        public String LogoutButton
        {
            get
            {
                return "//a[text()='Logout']";
            }
        }
    }
}
