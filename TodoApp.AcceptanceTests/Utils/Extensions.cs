using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodoApp.AcceptanceTests.Utils
{
    public static class Extensions
    {
        public static IWebElement FindVisibleElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            return driver.FindElement(by);
        }

        public static void Click(this IWebElement element, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var cnt = 0;
                do
                {
                    try
                    {
                        element.Click();
                        return; 
                    }
                    catch
                    {
                        Thread.Sleep(100);
                        cnt += 100;
                    }    
                } while (cnt < (timeoutInSeconds * 1000));
            }
            else
            {
                element.Click();
            }
            
        }
    }
}
