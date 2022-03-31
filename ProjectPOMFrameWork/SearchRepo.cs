using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOMFrameWork
{
    public class SearchRepo
    {

       public By elementFrequentSearch= By.XPath("//ul[@class='frequent-searches__items']//following::li");
        public By  elementFormSearch=  By.Id("new_form_search");
        public By elementFindbtn = By.XPath("//button[text()='Find']");
        public By elementSearchResultsCount = By.XPath("//h2[@class='search-results__counter']");
        public By elementSearchResultsItems = By.XPath("//div[@class='search-results__items']//following::article");
    }
}
