using OpenQA.Selenium;

namespace ShoppingCart.PageObjects
{
    class CartPage
    {
        public string getcartproductprice(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//div/span[@class='actual-price']")).Text;
        }
    }
}
