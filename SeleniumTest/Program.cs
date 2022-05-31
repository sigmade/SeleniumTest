using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var browser = new BrowserProcessor();
            browser.Start();
            browser.GoToSite();
            browser.Close();
        }
    }

    public class BrowserProcessor
    {
        IWebDriver driver;

        public void Start()
        {
            driver = new ChromeDriver("C:\\Users\\Admin501\\chromeDriver");
        }

        public void GoToSite()
        {
            var email = "..";
            var pass = "..";

            driver.Url = "..";
            Thread.Sleep(8000);
            var enterButton = driver.FindElement(By.ClassName("enter"));
            enterButton.Click();
            Thread.Sleep(2000);
            var emailInp = driver.FindElement(By.Id("Email"));
            emailInp.SendKeys(email);
            Thread.Sleep(4000);
            var passInp = driver.FindElement(By.Id("Password"));
            passInp.SendKeys(pass);
            Thread.Sleep(4000);
            driver.FindElement(By.ClassName("submit-button")).Click();
            Thread.Sleep(4500);
            driver.FindElement(By.ClassName("menu-search-wrap")).Click();
            Thread.Sleep(3500);
            var searchInp = driver.FindElement(By.XPath("//input[@placeholder='Введите ключевое слово / фразу ']"));
            searchInp.SendKeys("C#");
            searchInp.SendKeys(Keys.Enter);
            Thread.Sleep(4350);
            var href = driver.FindElement(By.CssSelector("a.gs-title"));
            href.Click();
            Thread.Sleep(4350);
        }

        public void Close()
        {
            driver.Close();
        }
    }
}
