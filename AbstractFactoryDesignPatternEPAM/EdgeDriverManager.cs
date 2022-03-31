using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternEPAM
{
    public class EdgeDriverManager :DriverManager
    {

        protected override void SetDriver()
        {
            var service = OpenQA.Selenium.Edge.EdgeDriverService.CreateDefaultService(@"C:\Thirumala\PersonalDocs\AbstractFactoryDesignPatternEPAM\AbstractFactoryDesignPatternEPAM\Drivers", @"msedgedriver.exe");
            service.UseVerboseLogging = true;
            service.UseSpecCompliantProtocol = true;
            service.Start();

            var options = new OpenQA.Selenium.Edge.EdgeOptions();           

            driver = new RemoteWebDriver(service.ServiceUrl, options);
        }
    }
}
