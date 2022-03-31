using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System;
using System.Collections;

namespace ProjectTDDFramework
{
    [TestClass]
    public class HomeSearchTestMethods
    {
        IWebDriver driver;
        IJavaScriptExecutor js;
        private object driverManger;

        [TestInitialize]
        public void SetUp() {

            //  driver = new ChromeDriver();            

            //driverManger = DriverManagerFactory.getManger(DriverType.CHROME);
            driver.Navigate().GoToUrl("https://www.epam.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
             js = (IJavaScriptExecutor)driver;
        }
        [TestMethod]
        public void HomePage()
        {
            /*Search*/
            driver.FindElement(By.XPath("//button[@class='header-search__button header__icon']")).Click();
            driver.FindElement(By.Id("new_form_search")).Click();
            var list =driver.FindElements(By.XPath("//ul[@class='frequent-searches__items']//following::li"));
            foreach (var item in list)
            {
                driver.FindElement(By.Id("new_form_search")).Click();
                System.Threading.Thread.Sleep(2000);
                if (item.Text.ToString()=="DevOps")
                {
                    System.Threading.Thread.Sleep(1000);
                    item.Click();

                    break;
                }
               
            }

            driver.FindElement(By.XPath("//button[text()='Find']")).Click();
            js.ExecuteScript("window.scrollBy(0, 250)", "");
            IWebElement results = driver.FindElement(By.XPath("//h2[@class='search-results__counter']"));
            String searchResults=results.Text.ToString();
            String[] strArr=searchResults.Split(' ');

            int resultsCount=int.Parse(strArr[0]);

            if (resultsCount > 10)
            {

                Console.WriteLine("More than 10 results were found" + resultsCount);
            }
            else
            {
                Console.WriteLine(resultsCount + "Less than 10 results were found");
            }

            var resultArticle = driver.FindElements(By.XPath("//div[@class='search-results__items']//following::article"));
            int count=resultArticle.Count;
            foreach(var item in resultArticle)
            {
                String Actualvalue= item.Text.ToString();
                Assert.IsTrue(Actualvalue.Contains("DevOps"));
            }

        }
    }
}
