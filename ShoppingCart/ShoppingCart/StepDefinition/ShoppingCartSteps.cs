using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using ShoppingCart.PageObjects;
using ShoppingCart.Resources;
using ShoppingCart.Utility;
using System;
using TechTalk.SpecFlow;

namespace ShoppingCart.StepDefinition
{
    [Binding]
    public sealed class ShoppingCartSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public ShoppingCartSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = DriverFactory.initbrowser("Chrome");
        HomePage hpage = new HomePage();
        ProductPage ppage = new ProductPage();
        CartPage cpage = new CartPage();
        string prodprice, cart_prodprice;
        private ILog _log;
                
        [Given(@"there is availability on (.*) for (.*)")]
        public void GivenThereIsAvailabilityOnFor(string shoppingwebsite, string product)
        {
            
            driver.Navigate().GoToUrl(Resource.websites[shoppingwebsite]);
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            PageFactory.InitElements(driver, hpage);
            string parenttab = driver.CurrentWindowHandle;
                    
            // Action Class
            Actions hoveraction = new Actions(driver);
            hoveraction.MoveToElement(hpage.MakeUp).Click().Perform();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            HelperFunctions.takescreenshotofpage(driver);
            driver.Close();
            
            driver.SwitchTo().Window(parenttab);

            hpage.Search.SendKeys(product);
            hpage.Search.SendKeys(Keys.Enter);

            PageFactory.InitElements(driver, ppage);     
            ppage.getproductelement(driver, product).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);        
        }

        [When(@"the (.*) is added to the shopping cart")]
        public void WhenTheIsAddedToTheShoppingCart(string category)
        {
            try
            {
                ppage.getcategoryelement(driver, category).Click();
            }
            catch (Exception E)
            {
                _log = LogManager.GetLogger(GetType());
                _log.Info(string.Format("Error {0}", E));
            }
            finally
            {
                prodprice = ppage.getproductprice(driver);
            }
            
            ppage.addtobag.Click();
            ppage.cart.Click();
        }

        [Then(@"the product is successfully added and price remains the same")]
        public void ThenTheProductIsSuccessfullyAddedAndPriceRemainsTheSame()
        {
            IWebElement frame = driver.FindElement(By.XPath("//iframe"));
            driver.SwitchTo().Frame(frame);
            cart_prodprice = cpage.getcartproductprice(driver);

            Assert.AreEqual(prodprice, cart_prodprice, "Not the same");
            driver.Quit();
        }
    }
}
