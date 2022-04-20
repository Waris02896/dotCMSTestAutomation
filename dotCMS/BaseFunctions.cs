using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using static dotCMS.WebDriverInstance;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;

namespace dotCMS
{
    [SetUpFixture]
    public class BaseFunctions
    {
        public static IWebDriver webDriver = WebDriverSingleton.GetInstance();

        
        public static void Start()
        {
            //webDriver.Manage().Window.Size = new Size(1920, 1600);
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "https://demo.dotcms.com/dotAdmin/?r=1650342880831";
        }

        
        public static void End()
        {
            webDriver.Close();
        }

        /*  --  Click Functions Starts -- */
        public void clickElement(By by, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(by);
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });
            element.Click();
        }

        public void clickElementByXPath(String str, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath(str));
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine (ex.Message);
                    return null;
                }
            });
            element.Click();
        }
        
        public void clickElementByLinkText(String str, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.LinkText(str));
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine (ex.Message);
                    return null;
                }
            });
            element.Click();
        }
        
        public void clickElementByID(String str, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.Id(str));
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine (ex.Message);
                    return null;
                }
            });
            element.Click();
        }
        
        public void clickElementByName(String str, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.Name(str));
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });
            element.Click();
        }
        
        public void clickElementByClassName(String str, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.ClassName(str));
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });
            element.Click();
        }
        
        public void clickElementByTagName(IWebElement element, String str, int index)
        {
            try
            {
                IWebElement _element = element.FindElements(By.TagName(str))[index];
                _element.Click();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /*  --  Click Functions Ends -- */

        /*  --  Input Element Function Starts  --  */
        
        public void InputElement(By by, String text, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(by);
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });

            element.SendKeys(text);
        }
        
        public void InputElementById(String by, String text, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.Id(by));
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });
            
            element.SendKeys(text);
        }
        
        public void InputElementByXPath(String by, String text, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.Id(by));
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });

            element.SendKeys(text);
        }
        
        public void InputElementByClassName(String by, String text, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.ClassName(by));
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });

            element.SendKeys(text);
        }
        
        public void InputElementByClassName(String by, String text, int index, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IList<IWebElement> list = webDriver.FindElements(By.ClassName(by));
                    if (list.Count > 0)
                    {
                        Thread.Sleep(interval);
                        return list[index];
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });

            element.SendKeys(text);
        }
        
        public void InputElement(WebElement element, String str)
        {
            try
            {
                element.SendKeys(str);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /*  --  Input Element Function Ends  --  */

        /*  --  Assertion Functions Starts  --  */
        public void MatchText(String org, String exp)
        {
            try
            {
                Assert.AreEqual(org, exp);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        public void ElementIsVisible(By by, int time)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        
        public void ElementIsPresent(By by, int time)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            try
            {
                wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public bool ElementClickAble(By by, int time)
        {
            WebDriverWait wait = new WebDriverWait (webDriver, TimeSpan.FromSeconds(time));
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(by));
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /*  --  Assertion Functions Ends  --  */

        /*  --  Shortcut Keys Functions Starts  --  */
        public void PressEnter(By by, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(by);
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });

            element.SendKeys(Keys.Enter);
        }
        
        public void ControlAll(By by, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(by);
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });

            element.SendKeys(Keys.Control + "a");
        }

        public void ControlAll(IWebElement element)
        {
            element.SendKeys(Keys.Control + "a");
        }

        public void Backspace(By by, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(by);
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });

            element.SendKeys(Keys.Backspace);
        }
        
        public void Backspace(IWebElement element)
        {
            element.SendKeys(Keys.Backspace);
        }
        /*  --  Shortcut Keys Functions Ends  --  */

        /*  --  Get Element Functions Starts  --  */
        public IWebElement getElement(By by, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IWebElement element = wait.Until(ele =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(by);
                    if (element != null)
                    {
                        Thread.Sleep(interval);
                        return element;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });

            return element;
        }
        
        public IList<IWebElement> getElementsByXPath(By by, int time, int interval)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(time));
            IList<IWebElement> list = wait.Until(ele =>
            {
                try
                {
                    IList<IWebElement> list = webDriver.FindElements(by);
                    if (list.Count > 0)
                    {
                        Thread.Sleep(interval);
                        return list;
                    }
                    else
                    {
                        Thread.Sleep(interval);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });

            return list;
        }
        /*  --  Get Element Functions Ends  --  */

        /*  --  Random Functions Starts  --  */
        public String RanfomString(int range)
        {
            Random RandomNumber = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[range];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[RandomNumber.Next(chars.Length)];
            }

            return new string(stringChars);
        }
        /*  --  Random Functions Ends  --  */


        public void SwitchToIframe()
        {
            webDriver.SwitchTo().Frame(webDriver.FindElement(By.TagName("iframe")));
        }

        public void SwitchToDefaultWindow()
        {
            webDriver.SwitchTo().DefaultContent();
        }
    }
}
