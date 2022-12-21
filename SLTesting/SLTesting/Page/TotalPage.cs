using OpenQA.Selenium;
using SLTesting.Driver;


namespace SLTesting.Page
{
    public class TotalPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement SauceLabsBikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement SauceLabsFleeceJacket => driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        public IWebElement T_ShirtRed => driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)"));
        public IWebElement Cart => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement Checkout => driver.FindElement(By.Id("checkout"));
        public IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => driver.FindElement(By.Id("last-name"));
        public IWebElement PostalCode => driver.FindElement(By.Id("postal-code"));
        public IWebElement Continue => driver.FindElement(By.Id("continue"));
    }
}
