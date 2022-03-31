using AbstractFactoryDesignPatternEPAM;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ProjectPOMFrameWork;
using ProjectUtilities;
using System;
using static AbstractFactoryDesignPatternEPAM.DriverManager;


namespace TestFactoryFramework
{
    [TestClass]
    public class SearchTestMethod
    {
        HomeHelper hp;
        SearchHelper searchHelper;

        IWebDriver driver;
        IJavaScriptExecutor js;
        DriverManager driverManger;
     
        [TestMethod]
        [DataRow(DriverType.CHROME)]  
        [DataRow(DriverType.EDGE)]
        public void HomePageSearch(DriverType type)
        {           
            GetSearchResults(type);
            int results= searchHelper.SearchResultsCount();
            Assert.AreNotEqual(0, results);
        }

        [TestMethod]
        [DataRow(DriverType.CHROME)]        
        public void SearchResultsValidation(DriverType type)
        {          
            GetSearchResults(type);
            Boolean validationflag = searchHelper.searchResultsValidation(Constants.searchKey);
            Assert.IsTrue(validationflag);
        }

        public void GetSearchResults(DriverType type) {
            DriverSetUp(type);
            hp = new HomeHelper(driver);
            searchHelper = new SearchHelper(driver);
            hp.ButtonClick(Constants.SearchIcon);
            hp.ButtonClick(Constants.SearchBox);
            searchHelper.SelectRequiredItemfromSearchList(Constants.searchKey);
            hp.ButtonClick(Constants.Finish);
        }
        
        public void DriverSetUp(DriverType type)
        {               

            driverManger = DriverManagerFactory.getManger(type);
            driver = driverManger.getDriver();
            driver.Navigate().GoToUrl("https://www.epam.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            js = (IJavaScriptExecutor)driver;
        }

        [TestCleanup]
        public void ClearBrowser() { 
        driverManger.quitDriver();
        }
    }
}
