using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryDesignPatternEPAM.DriverManager;

namespace AbstractFactoryDesignPatternEPAM
{
    public class DriverManagerFactory
    {

        public static DriverManager getManger(DriverType type)
        {
            DriverManager driverManager;
            switch (type)
            {
                case DriverType.CHROME:
                    driverManager = new ChromeDriverManger();                   
                    break;                
                default:
                    driverManager = new EdgeDriverManager();
                    break;

            }
            return driverManager;
        }

    }
}
