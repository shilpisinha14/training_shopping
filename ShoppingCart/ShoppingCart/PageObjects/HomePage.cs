using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ShoppingCart.PageObjects
{
    class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search on Nykaa']")]
        public IWebElement Search { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/ul/li/a[text()='makeup']")]
        public IWebElement MakeUp { get; set; }
    }
}
