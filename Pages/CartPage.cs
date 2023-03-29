using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumCSharpTraining.Pages
{
    public class CartPage : Base
    {
        public By bagItemLabel = By.Id("item_4_title_link");
        public By lightItemLabel = By.Id("item_0_title_link");
        public By tShirtItemLabel = By.Id("item_1_title_link");
        By btnRemoveLightItemFromCart = By.Id("remove-sauce-labs-bike-light");
        By btnRemoveBagItemFromCart = By.Id("remove-sauce-labs-backpack");
        By btnRemoveTShirtItemFromCart = By.Id("remove-sauce-labs-bolt-t-shirt");
        By btncontinueShopping = By.Id("continue-shopping");
        public By listaddedItems = By.CssSelector("div[class='cart_item']");
        public By lblitemsCount = By.CssSelector("#shopping_cart_container > a > span");

        public void ClickOnRemoveLightItemButton()
        {
            driver.FindElement(btnRemoveLightItemFromCart).Click();
        }

        public void ClickOnRemoveBagItemButton()
        {
            driver.FindElement(btnRemoveBagItemFromCart).Click();
        }

        public void ClickOnRemoveTShirtItemButton()
        {
            driver.FindElement(btnRemoveTShirtItemFromCart).Click();
        }

        public void ClickOnContinueShoppingButton()
        {
            driver.FindElement(btncontinueShopping).Click();
        }

        public IList<IWebElement> GetListOfAddedItems()
        {
            return driver.FindElements(listaddedItems);
        }

        public String GetCountOnCartIcon()
        {
            return driver.FindElement(lblitemsCount).Text;
        }
    }
}
