using OpenQA.Selenium;
using ProjectPOMFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUtilities
{
    public class HomeHelper
    {
        IWebDriver webdriver;
        Utilities ob;
        HomeRepo repo;
        SearchRepo searchRepo;
        public void ButtonClick(String buttonName)
        {
            ob=new Utilities(webdriver);
            repo=new HomeRepo();
            searchRepo=new SearchRepo();
            if (buttonName == Constants.SearchIcon) { ob.ClickElement(repo.elementSearchIcon); }
            else if (buttonName == Constants.SearchBox) { ob.ClickElement(repo.elementSearchbox); }
            else if (buttonName == Constants.Finish) { ob.ClickElement(searchRepo.elementFindbtn); }

            else { Console.WriteLine("button not existed"); }

        }

        public String getText(string text)
        {
            ob = new Utilities(webdriver);
            repo = new HomeRepo();
            searchRepo = new SearchRepo();



            return text;
        }

      
        public HomeHelper(IWebDriver driver) { this.webdriver = driver; }
    }
}
