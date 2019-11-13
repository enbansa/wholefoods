using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace tryfacebook
{
    [TestFixture]
    class test
    {
        IWebDriver wd;
        [OneTimeSetUp]
        public void setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            wd = new ChromeDriver(options);
            wd.Manage().Window.Maximize();
        }
        [Test, Order(1)]//case 1
        public void Openbrowser()
        {
            wd.Navigate().GoToUrl("https://www.facebook.com/");
        }
        [Test]

        public void VerifyLogin()
        {
            Openbrowser();
            // string email = ConfigurationSettings.AppSettings["email"];
            //string password = ConfigurationSettings.AppSettings["password"];

            var email = wd.FindElement(By.Id("email"));
            email.SendKeys("Anshumhz@gmail.com");
            var password = wd.FindElement(By.Id("pass"));
            password.SendKeys("America2015");
            var login = wd.FindElement(By.Id("loginbutton"));
            login.Click();
            Thread.Sleep(3000);
        }
        [Test]
        public void VerifyFriendList()
        {
            int ExpectedFriendList = 836;

            VerifyLogin();
            Thread.Sleep(3000);
            wd.FindElement(By.XPath("//*[@id='navItem_1731443537']/a/div")).Click();
            Thread.Sleep(3000);
            wd.FindElement(By.XPath("//*[@id='u_fetchstream_5_8']/li[3]/a")).Click();
            Thread.Sleep(3000);

            bool loop = true;
            while (loop)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)wd;
                js.ExecuteScript("window.scrollBy(0,1000");
                try
                {
                    var more = wd.FindElement(By.XPath("//*[@id='timeline - medley']/div/div[2]/div[1]/div/div/h3"));
                    if (more.Text != null)
                    {
                        loop = false;
                        break;
                    }
                }
                catch (NoSuchElementException e)
                {
                    loop = true;
                    Console.WriteLine(e);
                }
            }
            var nameElements = wd.FindElements(By.XPath("//*[@id='pagelet_timeline-app_collection_1731443537: 2356318349:2']/ul/li"));
            foreach (var nameElement in nameElements)
            {
                Console.WriteLine(nameElement.Text);
            }
        }
        
    }
}
