using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumCSharpTraining.Pages
{
    public class LoginPage: Base
    {
        By txtUsername = By.Id("user-name");
        By txtPassword = By.Id("password");
        By btnLogin = By.Id("login-button");
        

        public void SendUserName(String userName)
        {
            driver.FindElement(txtUsername).SendKeys(userName);
            //Thread.Sleep(2000);
        }

        public void SendPassword(String password)
        {
            driver.FindElement(txtPassword).SendKeys(password);
            //Thread.Sleep(2000);
        }

        public void ClickOnLoginButton()
        {
            driver.FindElement(btnLogin).Click();
        }
    }
}
