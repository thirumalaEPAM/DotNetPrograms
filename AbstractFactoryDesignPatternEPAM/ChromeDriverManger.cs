using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternEPAM
{
    public class ChromeDriverManger : DriverManager
    {     

        protected override  void SetDriver()
        {            
             driver = new ChromeDriver();
        }

    }
}
