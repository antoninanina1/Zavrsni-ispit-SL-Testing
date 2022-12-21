using OpenQA.Selenium;
using SLTesting.Driver;
using System;



namespace SLTesting.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement Username => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));
        public void LoginOnPage(string name, string pass)
        {
            Username.SendKeys(name);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }
    }
}
