using dotCMS.Locators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotCMS.Actions
{
    public class CMS013Actions
    {
        CMS013Locators locator = new CMS013Locators();
        BaseFunctions function = new BaseFunctions();
        private IWebElement element { get; set; }

        public void OpenMenu()
        {
            Thread.Sleep(5000);
            function.ElementIsVisible(locator.WelcomeHeadingLocator, 10);
            function.clickElementByXPath(locator.MenuLocator, 20, 250);

        }

        public void ContentForm()
        {
            Thread.Sleep(3000);
            function.clickElementByXPath(locator.ContentLocator, 20, 250);
            function.clickElementByLinkText(locator.SearchButton, 10, 250);
        }

        public void InputInPersonaFilter()
        {
            function.ElementIsVisible(locator.IframeTagLocator, 10);
            function.SwitchToIframe();
            function.ElementIsVisible(locator.AddPersonaLocator, 20);
            function.ControlAll(locator.FilterLocator, 10, 250);
            function.Backspace(locator.FilterLocator, 10, 250);
            function.InputElementById(locator.Filter, "Persona", 10, 250);
            function.PressEnter(locator.FilterLocator, 10, 250);
            Thread.Sleep(5000);
        }

        public void ClickPlusButton()
        {
            function.clickElement(locator.AddPersonaLocator, 10, 250);
        }

        public void OpenNewPersonaForm()
        {
            function.clickElementByID(locator.AddNewContent, 10, 250);
            function.SwitchToDefaultWindow();
            Thread.Sleep(2000);
            function.ElementIsVisible(locator.PersonaHeading, 10);
        }

        public void publish()
        {
            function.SwitchToIframe();
            element = function.getElement(locator.SavePublishDivision, 10, 250);
            function.clickElementByTagName(element, "a", 1);
            function.ElementIsVisible(locator.ErrorDialogue, 10);
            function.clickElement(locator.DialogueClose, 10, 250);
            function.SwitchToDefaultWindow();
            function.clickElementByXPath(locator.CloseButton, 10, 250);
        }
    }
}
