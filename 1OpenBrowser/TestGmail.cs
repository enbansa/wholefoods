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
using NUnit.Framework;

namespace _1OpenBrowser
{
    [TestFixture]
    class TestGmail
    {

        [Test]
        public void InvalidGmail()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.gmail.com");
            string ExpectedEmail = "Anshumhz@gmail.com";
            var email = driver.FindElement(By.XPath("//*[@id='identifierId']"));
            email.SendKeys("Anshumhz@gmai.com");
            Assert.AreEqual(ExpectedEmail, email);

        }
/*
        [Test]
        public void InvalidPassword()
        {

        }

        [Test]
        public void ValidEmail()
        {
        
        }

        [Test]
        public void ValidPassword()
        {

        }*/

    }
}
