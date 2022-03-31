using OpenQA.Selenium;

namespace AbstractFactoryDesignPatternEPAM
{
    public abstract class DriverManager
    {
        protected IWebDriver driver;
        
        protected abstract void SetDriver();
        public void quitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
        public  IWebDriver getDriver()
        {
            if (driver == null)
            {
                SetDriver();
               
            }
            return driver;
        }

        public enum DriverType
        {
            CHROME,
            EDGE,

        }
    }
}