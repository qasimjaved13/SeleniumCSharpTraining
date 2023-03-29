using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumCSharpTraining.Pages
{
    public class InventoryPage:Base
    {
        public By btnAddToCartBag = By.Id("add-to-cart-sauce-labs-backpack");
        public By btnAddToCartLight = By.Id("add-to-cart-sauce-labs-bike-light");
        public By btnAddToCartTShirt = By.Id("add-to-cart-sauce-labs-bolt-t-shirt");

        By btnShoppingCart = By.Id("shopping_cart_container");

        public void ClickOnAddToCartButtonForBag()
        {
            driver.FindElement(btnAddToCartBag).Click();
            //Thread.Sleep(3000);
        }

        public void ClickOnCartButton()
        {
            driver.FindElement(btnShoppingCart).Click();
            //Thread.Sleep(2000);
        }

        public void ClickOnAddToCartButtonForLight()
        {
            driver.FindElement(btnAddToCartLight).Click();
            //Thread.Sleep(2000);
        }

        public void ClickOnAddToCartButtonForTShirt()
        {
            driver.FindElement(btnAddToCartTShirt).Click();
            //Thread.Sleep(2000);
        }
    }
}
