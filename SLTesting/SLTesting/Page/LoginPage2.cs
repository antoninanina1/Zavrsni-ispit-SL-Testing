using OpenQA.Selenium;
using SLTesting.Driver;


namespace SLTesting.Page
{
    public class LoginPage2
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement Username => driver.FindElement(By.Name("user-name"));
        public IWebElement Password => driver.FindElement(By.Name("password"));
        public IWebElement LoginButton => driver.FindElement(By.Name("login-button"));
    }
}
