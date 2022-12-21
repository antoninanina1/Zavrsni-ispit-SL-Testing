using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SLTesting.Driver;

namespace SLTesting.Page
{
    public class CartPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement SortByPrice => driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement SauceLabsOnesie => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        public IWebElement SauceLabsBikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement SauceLabsBoltT_Shirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Cart => driver.FindElement(By.Id("shopping_cart_container"));
        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(SortByPrice);
            element.SelectByText(text);
        }
    }
}
