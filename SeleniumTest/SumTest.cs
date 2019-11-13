using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;



namespace SeleniumTest
{
    [TestFixture]
    class SumTest
    {
        IWebDriver wd;
        
        [OneTimeSetUp]
            public void SetUp()
        {
            wd = new FirefoxDriver();
        }
          
        //case 1
        public void OpenBrowser()
        {
            wd.Navigate().GoToUrl("https://www.w3schools.com/sql/sql_count_avg_sum.asp");
            
        }
        [Test]
        public void VerifySumOfTable()
        {
            OpenBrowser();
            double Sum = 0.0;
            double ExpectedSum = 90.35;
            var rows = wd.FindElements(By.XPath("//*[@id='main']/div[6]/table/tbody/tr/td[6]"));
            foreach (IWebElement row in rows)
            {
                double no = Double.Parse(row.Text);
                Sum += no;

            }
            Assert.AreEqual(ExpectedSum, Sum);
        }
        [Test]
        public void verifysumtablefail()
        {
            OpenBrowser();
            double Sum = 0.0;
            double ExpectedSum = 91.35;
            var rows = wd.FindElements(By.XPath("//*[@id='main']/div[6]/table/tbody/tr/td[6]"));
            foreach (IWebElement row in rows)
            {
                double no = Double.Parse(row.Text);
                Sum += no;

            }
            Assert.AreEqual(ExpectedSum, Sum);
        }
        
    }

  }     

      
    

