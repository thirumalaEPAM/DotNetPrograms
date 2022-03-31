using OpenQA.Selenium;
using ProjectPOMFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUtilities
{
    public class SearchHelper
    {
        IWebDriver webdriver;
        Utilities ob;
        HomeRepo repo;
        SearchRepo searchRepo;
       
        public void SelectRequiredItemfromSearchList(string searchkey)
        {
            ob = new Utilities(webdriver);      
            repo = new HomeRepo();
            searchRepo = new SearchRepo();

            try
            {
                var frequentSearchKeys = ob.getItemsList(searchRepo.elementFrequentSearch);
                foreach (var frequentSearchKey in frequentSearchKeys)
                {
                    ob.ClickElement(repo.elementSearchbox);

                    if (frequentSearchKey.Text.ToString() == searchkey)
                    {
                        ob.WaitforElemenLoad(10);
                        frequentSearchKey.Click();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public int SearchResultsCount()
        {

            ob = new Utilities(webdriver);
            repo = new HomeRepo();
            searchRepo = new SearchRepo();
            int resultsCount = 0;
            try
            {
                ob.pageScroll(searchRepo.elementFindbtn);
                String searchResults = ob.getElementText(searchRepo.elementSearchResultsCount);

                String[] strArr = searchResults.Split(' ');

                 resultsCount = int.Parse(strArr[0]);

                if (resultsCount > 10)
                {

                    Console.WriteLine("More than 10 results were found" + resultsCount);
                }
                else
                {
                    Console.WriteLine(resultsCount + "Less than 10 results were found");
                }
            }
            catch (Exception ex) {
                resultsCount = 0;
                Console.WriteLine(ex.StackTrace);
            }

            return resultsCount;
        }

        

        public Boolean searchResultsValidation(string searchkey) {

            ob = new Utilities(webdriver);
            repo = new HomeRepo();
            searchRepo = new SearchRepo();
            Boolean flag = false;
            try
            {
                ob.pageScroll(searchRepo.elementFindbtn);
                var resultArticle = ob.getItemsList(searchRepo.elementSearchResultsItems);

                int count = resultArticle.Count;

                foreach (var item in resultArticle)
                {
                    string Actualvalue = item.Text.ToString();
                    if (Actualvalue.Contains(searchkey))
                    {
                        flag = true;
                    }
                }
            }
            catch (Exception ex) { 
                flag = false;
                Console.WriteLine(ex.StackTrace);
            }
            return flag;
        }
        public SearchHelper(IWebDriver driver) { this.webdriver = driver; }
    }
}
