using OpenQA.Selenium;
using SLTesting.Driver;
using NUnit.Framework;
using SLTesting.Page;


namespace SLTesting
{
    public class Tests
    {
        private LoginPage loginPage;
        private LoginPage2 loginPage2;
        private CartPage cartPage;
        private CartPage2 cartPage2;
        private ItemTotalPage itemTotalPage;
        private TotalPage totalPage;
        private FinishOrderPage finishOrderPage;
       
        [SetUp]
        public void SetUp()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            loginPage2 = new LoginPage2();
            cartPage = new CartPage();
            cartPage2 = new CartPage2();
            itemTotalPage = new ItemTotalPage();
            totalPage = new TotalPage();
            finishOrderPage = new FinishOrderPage();
            
        }
        [TearDown]
        public void CleanUp()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_LoginOnPage_PageShouldBeLogged()
        {
            loginPage.Username.SendKeys("standard_user");
            loginPage.Password.SendKeys("secret_sauce");
            loginPage.LoginButton.Submit();

            Assert.That("https://www.saucedemo.com/inventory.html", Is.EqualTo(WebDrivers.Instance.Url));
        }
        [Test]
        public void TC02_LoginOnPage_PageShouldBeLoggedWithDifferentData()
        {
            loginPage2.Username.SendKeys("standard_user");
            loginPage2.Password.SendKeys("secret_sauce");
            loginPage2.LoginButton.Submit();

            Assert.That("https://www.saucedemo.com/inventory.html", Is.EqualTo(WebDrivers.Instance.Url));
        }
        [Test]
        public void TC03_SortProductByPrice_PriceShouldBeSorted()
        {
            loginPage2.Username.SendKeys("standard_user");
            loginPage2.Password.SendKeys("secret_sauce");
            loginPage2.LoginButton.Submit();

            cartPage.SelectOption("Price (high to low)");
            cartPage.SauceLabsOnesie.Click();
            cartPage.SauceLabsBikeLight.Click();
            cartPage.SauceLabsBoltT_Shirt.Click();
            cartPage.Cart.Click();

            Assert.That("https://www.saucedemo.com/cart.html", Is.EqualTo(WebDrivers.Instance.Url));
        }
        [Test]
        public void TC04_RemoveProductFromTheBasket_ProductShouldBeRemoved()
        {
            loginPage2.Username.SendKeys("standard_user");
            loginPage2.Password.SendKeys("secret_sauce");
            loginPage2.LoginButton.Submit();

            cartPage2.SauceLabsBackpack.Click();
            cartPage2.SauceLabsFleeceJacket.Click();
            cartPage2.Cart.Click();
            cartPage2.RemoveLabsBackpack.Click();
            cartPage2.RemoveLabsFleeceJacket.Click();
            
            Assert.That("https://www.saucedemo.com/cart.html", Is.EqualTo(WebDrivers.Instance.Url));
        }
        [Test]
        public void TC05_CheckingItemTotal_ItemTotalShouldBeCheck()
        {
            loginPage2.Username.SendKeys("standard_user");
            loginPage2.Password.SendKeys("secret_sauce");
            loginPage2.LoginButton.Submit();

            itemTotalPage.SauceLabsBackpack.Click();
            itemTotalPage.SauceLabsBoltT_Shirt.Click();
            itemTotalPage.SauceLabsOnesie.Click();
            itemTotalPage.Cart.Click();
            itemTotalPage.Checkout.Click();
            itemTotalPage.FirstName.SendKeys("antonina");
            itemTotalPage.LastName.SendKeys("tasic");
            itemTotalPage.PostalCode.SendKeys("11000");
            itemTotalPage.Continue.Click();

            Assert.That("https://www.saucedemo.com/checkout-step-two.html", Is.EqualTo(WebDrivers.Instance.Url));
        }
        [Test]
        public void TC06_CheckingTotal_TotalShouldBeCheck()
        {
            loginPage2.Username.SendKeys("standard_user");
            loginPage2.Password.SendKeys("secret_sauce");
            loginPage2.LoginButton.Submit();

            totalPage.SauceLabsBikeLight.Click();
            totalPage.SauceLabsFleeceJacket.Click();
            totalPage.T_ShirtRed.Click();
            totalPage.Cart.Click();
            totalPage.Checkout.Click();
            totalPage.FirstName.SendKeys("antonina");
            totalPage.LastName.SendKeys("tasic");
            totalPage.PostalCode.SendKeys("11000");
            totalPage.Continue.Click();

            Assert.That("https://www.saucedemo.com/checkout-step-two.html", Is.EqualTo(WebDrivers.Instance.Url));
        }
        [Test]
        public void TC07_FinishOrderProduct_OrderingProductShouldBeFinished()
        {
            loginPage2.Username.SendKeys("standard_user");
            loginPage2.Password.SendKeys("secret_sauce");
            loginPage2.LoginButton.Submit();

            finishOrderPage.SauceLabsBackpack.Click();
            finishOrderPage.SauceLabsBikeLight.Click();
            finishOrderPage.SauceLabsBoltTShirt.Click();
            finishOrderPage.SauceLabsFleeceJacket.Click();
            finishOrderPage.SauceLabsOnesie.Click();
            finishOrderPage.T_ShirtRed.Click();
            finishOrderPage.Cart.Click();
            finishOrderPage.Checkout.Click();
            finishOrderPage.FirstName.SendKeys("antonina");
            finishOrderPage.LastName.SendKeys("tasic");
            finishOrderPage.PostalCode.SendKeys("11000");
            finishOrderPage.Continue.Click();
            finishOrderPage.Finish.Click();

            Assert.That("https://www.saucedemo.com/checkout-complete.html", Is.EqualTo(WebDrivers.Instance.Url));
        }
    }
}