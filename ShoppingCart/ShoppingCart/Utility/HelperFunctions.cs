using OpenQA.Selenium;

namespace ShoppingCart.Utility
{
    static class HelperFunctions
    {
        public static void takescreenshotofpage(IWebDriver driver)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Screenshot\Screenshot.png", ScreenshotImageFormat.Png);
        }

        public static void jsclick(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }
    }
}
