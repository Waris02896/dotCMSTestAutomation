using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotCMS.Locators
{
    public class CMS001Locators
    {
        public By WelcomeHeadingLocator
        {
            get
            {
                return By.XPath("//h2[text()='Welcome!']");
            }
        }
        
        public String WelcomeHeading
        {
            get
            {
                return "//h2[text()='Welcome!']";
            }
        }

        public String MenuLocator
        {
            get
            {
                return "//i[text()='menu']";
            }
        }

        public String ContentLocator
        {
            get
            {
                return "//span[text()='Content']";
            }
        }

        public String SearchButton
        {
            get
            {
                return "Search";
            }
        }

        //public String AddPersona //classname
        //{
        //    get
        //    {
        //        return "fa=plus";
        //    }
        //}
        
        public By AddPersonaLocator //classname
        {
            get
            {
                return By.XPath("//span[@data-dojo-attach-point='_buttonNode']");
                //return By.ClassName("dijitDropDownButton");
            }
        }

        public String Filter //id
        {
            get
            {
                return "structure_inode";
            }
        }
        
        public By FilterLocator //id
        {
            get
            {
                return By.Id("structure_inode");
            }
        }

        public String AddNewContent //id
        {
            get
            {
                return "dijit_MenuItem_2_text";
            }
        }

        public By PersonaHeading
        {
            get
            {
                return By.XPath("//h4[text()='Persona']");
            }
        }

        public By IframeTagLocator
        {
            get
            {
                return By.TagName("iframe");
            }
        }

        public String NameInputField
        {
            get
            {
                return "name";
            }
        }

        public string EditButton
        {
            get
            {
                return "//span[text()='Edit']";
            }
        }

        public string KeyTag
        {
            get
            {
                return "showKeyTag";
            }
        }

        public By SavePublishDivision
        {
            get
            {
                return By.XPath("//div[contains(@class,'content-edit-actions')]");
            }
        }

        public String CloseButton
        {
            get
            {
                return "//*[text()='close']";
            }
        }

        public By ContentSavedAlert
        {
            get
            {
                return By.XPath("//div[contains(@class,'systemMessages')]");
            }
        }
    }
}
