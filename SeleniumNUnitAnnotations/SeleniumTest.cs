using NUnit.Framework;
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
using OpenQA.Selenium.IE;

namespace SeleniumNUnitAnnotations
{[TestFixture]
    class SeleniumTest
    {
        IWebDriver wd = null;
        string title;
        string browser = "Firefox";

        [OneTimeSetUp]// perform operatiob before running the test
        
        public void SetUpBrowser()
        {
            Console.WriteLine("Initial Settings are here");

            switch (browser)
            {
                case "Chrome":
                    wd = new ChromeDriver();
                    break;

                case "FireFox":
                    wd = new FireFoxDriver();
                    break;

                case "IE":
                    wd = new InternetExplorerDriver();
                    break;


            }
        }
         [Test] //case 1
         public void OpenBrowser()
        {
            wd.Navigate().GoToUrl("http://www.Facebook.com");
            title = wd.Title;
        }
        [Test]
        public void VerifyTitleOfPAgePass()
        {
            string expectedTitle = "Facebook - Log In or Sign UP";
            string actualTitle = wd.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [Test]
        public void VerifyTitleOfPAgeFail()
        {
            string expectedTitle = "Faceboo - Log In or Sign UP";
            string actualTitle = wd.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }

    

    

}

