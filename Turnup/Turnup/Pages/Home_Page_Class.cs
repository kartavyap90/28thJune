﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnup.Utilities;

namespace Turnup.Pages
{
    public class Home_Page_Class
    {
        public void Go_To_TM_Page_Func(IWebDriver driver)
        {
            Wait_Class.Wait_To_Be_Clickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 20);
            IWebElement menu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            menu.Click();

            Wait_Class.Wait_To_Be_Clickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 20);

            IWebElement timeandmaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeandmaterials.Click();
            

        }

        public void Go_To_Employee_Page_Func(IWebDriver driver)
        {
            Wait_Class.Wait_To_Be_Clickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 20);
            IWebElement menu1 = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            menu1.Click();

            Wait_Class.Wait_To_Be_Clickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a", 20);
            IWebElement employees = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employees.Click();

        }
    }
}
