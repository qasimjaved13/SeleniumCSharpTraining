using System;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTraining.Pages;

namespace SeleniumCSharpTraining
{
    [TestClass]
    public class Login : Base
    {
        LoginPage lg = new LoginPage();
        String userName = "standard_user";
        String password = "secret_sauce";

        public static ExtentTest extentTest;
        public static ExtentReports extentReport;
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void CreateExtentReport(TestContext testContext)
        {
            var reportPath = new ExtentHtmlReporter("D:\\SeleniumCSharp\\SeleniumCSharpTraining\\ExtentReport\\");
            extentReport = new ExtentReports();
            extentReport.AttachReporter(reportPath);
        }

        [ClassCleanup]
        public static void FlushReport()
        {
            extentReport.Flush();
        }

        [TestMethod]
        public void ValidUsernameAndPassword()
        {
            extentTest = extentReport.CreateTest("User should login with valid credentials.");
            extentTest.Log(Status.Info, "Sending Username");
            lg.SendUserName(userName);

            extentTest.Log(Status.Info, "Sending Password");
            lg.SendPassword(password);

            extentTest.Log(Status.Info, "Clickng on Login button");
            lg.ClickOnLoginButton();

            string url = driver.Url;
            Console.WriteLine("Hello! Welcome to " + url + " You have logged in with username \"" + userName + "\"");

            extentTest.Log(Status.Info, "Performing assestions");
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", url);
            extentTest.Log(Status.Pass);

        }

        [TestMethod]
        public void InvalidPassword()
        {
            extentTest = extentReport.CreateTest("User should not login with invalid password.");
            extentTest.Log(Status.Info, "Sending valid Username");
            lg.SendUserName(userName);

            extentTest.Log(Status.Info, "Sending invalid Password");
            lg.SendPassword("secret_sauce123");

            extentTest.Log(Status.Info, "Clickng on Login button");
            lg.ClickOnLoginButton();

            extentTest.Log(Status.Info, "Performing assestions");
            Assert.AreNotEqual("https://www.saucedemo.com/inventory.html", driver.Url);
            extentTest.Log(Status.Pass);

        }

        [TestMethod]
        public void InvalidUsername()
        {
            extentTest = extentReport.CreateTest("User should not login with invalid username.");
            extentTest.Log(Status.Info, "Sending invalid Username");
            lg.SendUserName("standard_user123");

            extentTest.Log(Status.Info, "Sending valid Password");
            lg.SendPassword(password);

            extentTest.Log(Status.Info, "Clickng on Login button");
            lg.ClickOnLoginButton();

            extentTest.Log(Status.Info, "Performing assestions");
            Assert.AreNotEqual("https://www.saucedemo.com/inventory.html", driver.Url);
            extentTest.Log(Status.Pass);

        }

        [TestMethod]
        public void WithoutUsernameAndPassword()
        {
            extentTest = extentReport.CreateTest("User should not login without username and password .");
            extentTest.Log(Status.Info, "Clickng on Login button without inserting Username and Password");
            lg.ClickOnLoginButton();

            extentTest.Log(Status.Info, "Performing assestions");
            Assert.AreNotEqual("https://www.saucedemo.com/inventory.html", driver.Url);
            extentTest.Log(Status.Pass);
        }
    }
}