using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOMFrameWork
{
    public class Utilities
    {
        IWebDriver webdriver;

        public IWebElement WaitForElement(By elt)
        {

            WebDriverWait wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(5));
            return wait.Until(X => X.FindElement(elt));
        }
        public void WaitforElemenLoad(int sec)
        {
            System.Threading.Thread.Sleep(sec);
        }
        public String getElementText(By elt)
        {

            return WaitForElement(elt).Text.ToString();
        }

        public void SendText(By elt, String text)
        {

            WaitForElement(elt).SendKeys(text);

        }

        public int getNumProdcts(By elt)
        {
            ReadOnlyCollection<IWebElement> prodcts = webdriver.FindElements(elt);

            int Count = prodcts.Count();
            return Count;
        }
        public ReadOnlyCollection<IWebElement> getItemsList(By by)
        {
            return webdriver.FindElements(by);
        }

        public void ClickElement(By elt)
        {
            WaitForElement(elt).Click();
        }

        public void pageScroll(By elt)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)webdriver;
            js.ExecuteScript("window.scrollBy(0, 250)", "");


        }
        public Utilities(IWebDriver driver) 
        { 
            this.webdriver = driver; 
        }

    }
}

