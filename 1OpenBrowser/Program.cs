using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace _1OpenBrowser
{
    class Program
    {
      

        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.gmail.com");

            var email = driver.FindElement(By.XPath("//*[@id='identifierId']"));
            email.SendKeys("Anshumhz@gmail.com");

            var next = driver.FindElement(By.XPath("//*[@id='identifierNext']/span/span"));
            next.Click();

            //thread sleep
            //Thread.Sleep(8000);
            //Implicit waits
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Explicit 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var psw= wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            
            
           var password = driver.FindElement(By.XPath("//*[@id='password']/div[1]/div/div[1]/input"));
            password.SendKeys("absx123");

            var next1 = driver.FindElement(By.XPath(("//*[@id='passwordNext']/span")));
            next1.Click();

            
        }
    }
}
