using dotCMS.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotCMS.Actions
{
    public class LoginActions
    {
        LoginLocators locator = new LoginLocators();
        BaseFunctions functions = new BaseFunctions();

        public void Login()
        {
            functions.ElementIsVisible(locator.loginLogoLocator, 10);
            functions.InputElementById(locator.emailInput, "admin@dotcms.com", 10, 250);
            functions.InputElementByClassName(locator.passwordInput, "admin", 2, 10, 250);
            functions.clickElementByXPath(locator.signInButton, 10, 250);
        }

        
    }
}
