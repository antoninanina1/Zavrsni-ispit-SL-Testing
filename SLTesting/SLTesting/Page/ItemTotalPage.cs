using OpenQA.Selenium;
using SLTesting.Driver;


namespace SLTesting.Page
{
    public class ItemTotalPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement SauceLabsBackpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement SauceLabsBoltT_Shirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement SauceLabsOnesie => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        public IWebElement Cart => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement Checkout => driver.FindElement(By.Id("checkout"));
        public IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => driver.FindElement(By.Id("last-name"));
        public IWebElement PostalCode => driver.FindElement(By.Id("postal-code"));
        public IWebElement Continue => driver.FindElement(By.Id("continue"));
    }
}
