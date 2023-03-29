using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTraining.Pages;

namespace SeleniumCSharpTraining.Tests
{
    [TestClass]
    public class Cart : Base
    {
        Login login = new Login();
        CartPage cp = new CartPage();
        InventoryPage ip = new InventoryPage();

        [TestMethod]
        public void RemoveLightItemFromCart()
        {
            login.ValidUsernameAndPassword();
            ip.ClickOnAddToCartButtonForLight();
            ip.ClickOnCartButton();
            cp.ClickOnRemoveLightItemButton();
            cp.ClickOnContinueShoppingButton();
            Assert.IsNotNull(driver.FindElement(ip.btnAddToCartLight));
        }

        [TestMethod]
        public void RemoveAllItemsFromCart()
        {
            login.ValidUsernameAndPassword();
            ip.ClickOnAddToCartButtonForBag();
            ip.ClickOnAddToCartButtonForLight();
            ip.ClickOnAddToCartButtonForTShirt();
            ip.ClickOnCartButton();
            cp.ClickOnRemoveLightItemButton();
            cp.ClickOnRemoveBagItemButton();
            cp.ClickOnRemoveTShirtItemButton();
            cp.ClickOnContinueShoppingButton();

            /*var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ip.btnAddToCartBag));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ip.btnAddToCartLight));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ip.btnAddToCartTShirt));*/

            Assert.IsNotNull(driver.FindElement(ip.btnAddToCartBag));
            Assert.IsNotNull(driver.FindElement(ip.btnAddToCartLight));
            Assert.IsNotNull(driver.FindElement(ip.btnAddToCartTShirt));
        }
    }
}
    