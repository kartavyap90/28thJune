using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnup.Utilities;

namespace Turnup.Pages
{
    public class Employee_Page_Class
    {

        public void Create_Employee(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"container\"]/p/a", 20);
            IWebElement Create_Button = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            Create_Button.Click();

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"Name\"]", 20);
            IWebElement Name_Textbox = driver.FindElement(By.XPath("//*[@id=\"Name\"]"));
            Name_Textbox.Click();
            Name_Textbox.SendKeys("Ashok");

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"Username\"]", 20);
            IWebElement Username_Textbox = driver.FindElement(By.XPath("//*[@id=\"Username\"]"));
            Username_Textbox.Click();
            Username_Textbox.SendKeys("Ash");

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"Password\"]", 20);
            IWebElement Password_Textbox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            Password_Textbox.Click();
            Password_Textbox.SendKeys("Ashok!23");

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"RetypePassword\"]", 20);
            IWebElement RetypePassword_Textbox = driver.FindElement(By.XPath("//*[@id=\"RetypePassword\"]"));
            RetypePassword_Textbox.Click();
            RetypePassword_Textbox.SendKeys("Ashok!23");

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"UserEditForm\"]/div/div[8]/div/div", 20);
            IWebElement Groups_Dropdown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div"));
            Groups_Dropdown.Click();

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"groupList_listbox\"]/li[2]", 20);
            IWebElement Groups = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[2]"));
            Groups.Click();

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"SaveButton\"]", 20);
            IWebElement Save_Button = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            Save_Button.Click();
            

        }

        public void Edit_Employee(IWebDriver driver)
        {
            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"container\"]/div/a", 20);
            IWebElement Back_To_List = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            Back_To_List.Click();

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 20);
            IWebElement Go_To_Last_Page_Button = driver.FindElement(By.XPath(" //*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            Go_To_Last_Page_Button.Click();

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 20);
            IWebElement Last_Employee_Name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if(Last_Employee_Name.Text == "Ashok")
            {
                Assert.Pass("\n Employee name found");
                Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]", 20);
                IWebElement Edit_Button = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                Edit_Button.Click();

                
                Wait_Class.Wait_To_Be_Clickable(driver,"XPath", "//*[@id=\"Name\"]", 20);
                IWebElement Name_Textbox = driver.FindElement(By.XPath("//*[@id=\"Name\"]"));
                Name_Textbox.Click();
                Name_Textbox.SendKeys("Ashoka");

                Wait_Class.Wait_To_Be_Clickable(driver,"XPath", "//*[@id=\"Username\"]", 20);
                IWebElement Username_Textbox = driver.FindElement(By.XPath("//*[@id=\"Username\"]"));
                Username_Textbox.Click();
                Username_Textbox.SendKeys("Asha");

                Wait_Class.Wait_To_Be_Clickable(driver,"XPath", "//*[@id=\"Password\"]", 20);
                IWebElement Password_Textbox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
                Password_Textbox.Click();
                Password_Textbox.SendKeys("Ashoka!23");

                Wait_Class.Wait_To_Be_Clickable(driver,"XPath", "//*[@id=\"RetypePassword\"]", 20);
                IWebElement RetypePassword_Textbox = driver.FindElement(By.XPath("//*[@id=\"RetypePassword\"]"));
                RetypePassword_Textbox.Click();
                RetypePassword_Textbox.SendKeys("Ashoka!23");

                Wait_Class.Wait_To_Be_Clickable(driver,"XPath", "//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]", 20);
                IWebElement Groups_Dropdown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
                Groups_Dropdown.Click();

                Wait_Class.Wait_To_Be_Clickable(driver,"XPath", "//*[@id=\"groupList_listbox\"]/li[3]", 20);
                IWebElement Groups = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[3]"));
                Groups.Click();

                Wait_Class.Wait_To_Be_Clickable(driver,"XPath", "//*[@id=\"SaveButton\"]", 20);
                IWebElement Save_Button = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
                Save_Button.Click();
            }
            else 
            { 
                Assert.Fail("Given Employee naem not found at last row of grid."); 
            }
        }

        public void Delete_Employee(IWebDriver driver)
        {
            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"container\"]/div/a", 20);
            IWebElement Back_To_List = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            Back_To_List.Click();

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 20);
            IWebElement Go_To_Last_Page_Button = driver.FindElement(By.XPath(" //*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            Go_To_Last_Page_Button.Click();

            Wait_Class.Wait_To_Be_Clickable(driver,"XPath","//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[3]/td[3]/a[2]", 20);
            IWebElement Delete_Button = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[3]/td[3]/a[2]"));
            Delete_Button.Click();
        }

    }
}
