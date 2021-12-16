using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ShoppingCart.PageObjects
{
    class ProductPage
    {
        [FindsBy(How =How.XPath, Using = "//button/span[text()='ADD TO BAG'][1]")]
        public IWebElement addtobag;

        [FindsBy(How = How.XPath, Using = "//button[@class='css-5s18zx eoh7kvv0']")]
        public IWebElement cart;

        public IWebElement getproductelement(IWebDriver driver, string product)
        {
            return driver.FindElement(By.XPath("//div/img[contains(@alt,'" + product + "')][1]"));
        }

        public IWebElement getcategoryelement(IWebDriver driver, string category)
        {
            return driver.FindElement(By.XPath("//span/img[contains(@alt,'" + category + "')]"));
        }

        public string getproductprice(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//span[@class='css-12x6n3h']")).Text;
        }            
    }
}
