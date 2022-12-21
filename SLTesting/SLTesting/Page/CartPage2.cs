using OpenQA.Selenium;
using SLTesting.Driver;


namespace SLTesting.Page
{
    public class CartPage2
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement SauceLabsBackpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement SauceLabsFleeceJacket => driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        public IWebElement Cart => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement RemoveLabsBackpack => driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement RemoveLabsFleeceJacket => driver.FindElement(By.Id("remove-sauce-labs-fleece-jacket"));       
    }
}
