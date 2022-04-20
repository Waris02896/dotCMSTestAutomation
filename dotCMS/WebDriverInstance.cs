using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotCMS
{
    public class WebDriverInstance
    {
        public sealed class WebDriverSingleton
        {
            private static IWebDriver instance = null;
            private WebDriverSingleton() { }
            public static IWebDriver GetInstance()
            {
                if (instance == null)
                {
                    instance = new ChromeDriver(".");
                }

                return instance;
            }
        }
    }
}
