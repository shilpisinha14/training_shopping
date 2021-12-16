using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace ShoppingCart.Utility
{
    class DriverFactory  //implements factory design pattern
    {
        private static IWebDriver driver = null;
        private DriverFactory() { }
        public static IWebDriver initbrowser(string browsername)
        {
             if(driver == null)
             {
                    if(browsername.Equals("Chrome"))
                    {
                        driver = new ChromeDriver(@"C:\Users\Shilpi_Sinha\Downloads\chromedriver_win32");
                    }
                    else if(browsername.Equals("Edge"))
                    {
                        driver = new EdgeDriver(@"C:\Users\Shilpi_Sinha\Downloads\edgedriver_win64");
                    }
             }
             return driver;
        }

    }
}
