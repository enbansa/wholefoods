using java.sql;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlertBox
{
    class Program
    {
        static IWebDriver driver = new ChromeDriver();
        static IAlert Alert;

        static void Main(string[] args)
        {
            driver.Navigate().GoToUrl("http://testing.todvachev.com/category/special-elements/");
            var box = driver.FindElement(By.XPath("//*[@id='main-content']/article[1]/div[2]/header/h3/a"));
            box.Click();
            Thread.Sleep(3000);
            Alert = driver.SwitchTo().Alert();
            Alert.Accept();
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
