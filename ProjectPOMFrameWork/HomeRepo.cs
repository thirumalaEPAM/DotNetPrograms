using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOMFrameWork
{
    public class HomeRepo
    {
        public By elementSearchIcon = By.XPath("//button[@class='header-search__button header__icon']");
        public By elementSearchbox = By.Id("new_form_search");
    }
}
