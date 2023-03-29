using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumCSharpTraining.Pages;

namespace SeleniumCSharpTraining.Tests
{
    [TestClass]
    public class Inventory : Base
    {
        InventoryPage ip = new InventoryPage();
        CartPage cp = new CartPage();
        Login login = new Login();

        [TestMethod]
        public void AddAnItemToCart()
        {
            login.ValidUsernameAndPassword();
            ip.ClickOnAddToCartButtonForBag();
            ip.ClickOnCartButton();

            Console.WriteLine("Navigated to " + driver.Url + " URL.");
            Console.WriteLine("You have added " + cp.GetListOfAddedItems().Count() + " items into cart.");
            Console.WriteLine("Count on the shopping cart icon is: " + cp.GetCountOnCartIcon());

            Assert.AreEqual("https://www.saucedemo.com/cart.html", driver.Url);
            Assert.AreEqual("Sauce Labs Backpack", driver.FindElement(cp.bagItemLabel).Text);
            Assert.AreEqual(Convert.ToString(cp.GetListOfAddedItems().Count()), cp.GetCountOnCartIcon());

        }

        [TestMethod]
        public void AddTwoItemsToCart()
        {
            login.ValidUsernameAndPassword();
            ip.ClickOnAddToCartButtonForBag();
            ip.ClickOnAddToCartButtonForLight();
            ip.ClickOnCartButton();

            Console.WriteLine("Navigated to " + driver.Url + " URL.");
            Console.WriteLine("You have added " + cp.GetListOfAddedItems().Count() + " items into cart.");
            Console.WriteLine("Count on the shopping cart icon is: " + cp.GetCountOnCartIcon());

            Assert.AreEqual("https://www.saucedemo.com/cart.html", driver.Url);
            Assert.AreEqual("Sauce Labs Backpack", driver.FindElement(cp.bagItemLabel).Text);
            Assert.AreEqual("Sauce Labs Bike Light", driver.FindElement(cp.lightItemLabel).Text);
            Assert.AreEqual(Convert.ToString(cp.GetListOfAddedItems().Count()), cp.GetCountOnCartIcon());

        }

        [TestMethod]
        public void AddThreeItemsToCart()
        {
            login.ValidUsernameAndPassword();
            ip.ClickOnAddToCartButtonForBag();
            ip.ClickOnAddToCartButtonForLight();
            ip.ClickOnAddToCartButtonForTShirt();
            ip.ClickOnCartButton();

            Console.WriteLine("Navigated to " + driver.Url + " URL.");
            Console.WriteLine("You have added " + cp.GetListOfAddedItems().Count() + " items into cart.");
            Console.WriteLine("Count on the shopping cart icon is: " + cp.GetCountOnCartIcon());

            Assert.AreEqual("https://www.saucedemo.com/cart.html", driver.Url);
            Assert.AreEqual("Sauce Labs Backpack", driver.FindElement(cp.bagItemLabel).Text);
            Assert.AreEqual("Sauce Labs Bike Light", driver.FindElement(cp.lightItemLabel).Text);
            Assert.AreEqual("Sauce Labs Bolt T-Shirt", driver.FindElement(cp.tShirtItemLabel).Text);
            Assert.AreEqual(Convert.ToString(cp.GetListOfAddedItems().Count()), cp.GetCountOnCartIcon());
        }
    }
}
