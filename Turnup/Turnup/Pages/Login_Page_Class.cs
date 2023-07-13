using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnup.Utilities;

namespace Turnup.Pages
{
    public class Login_Page_Class
    {
        public void Login_Steps_Func(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //Login into portal and verify user name
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            Wait_Class.Wait_To_Be_Clickable(driver, "XPath", "//*[@id=\"loginForm\"]/form/div[3]/input[1]", 20);
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("User has logged Successfully");
            }
            else
            {
                Console.WriteLine("User has not logged in Successfully");
            }
        }
    }
}
