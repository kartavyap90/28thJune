using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpSpecFlowProject.Pages
{
    public class TM_Page_Class
    {
        public void Create_Time_Record_Func(IWebDriver driver,string code, string description, string price)
        {
            Console.WriteLine("\nNow cursor entered into Create_Time_Record_Func().");
            Wait_Class.Wait_To_Be_Clickable(driver, "XPath", "//*[@id=\"container\"]/p/a", 20);
            IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewbutton.Click();

            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.Clear();
            codetextbox.SendKeys(code);

            IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
            descriptiontextbox.Clear();
            descriptiontextbox.SendKeys(description);

            IWebElement Price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            Price.Click();

            IWebElement pricetextbox = driver.FindElement(By.Id("Price"));
            pricetextbox.Clear();
            pricetextbox.SendKeys(price);

            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            //codetextbox.Clear(); descriptiontextbox.Clear(); pricetextbox.Clear();
            //Console.WriteLine("Details inserted as value are 1, first description, 100, Test Passed.");
        }

        public void AssertCreateTimeRecord(IWebDriver driver, string code)
        {
            Thread.Sleep(4000);
            IWebElement go_to_last_page_button1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            go_to_last_page_button1.Click();
            Thread.Sleep(4000);
            IWebElement New_Code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //Console.Write("\nValue found at last row is=>"); Console.Write(New_Code.Text);
            Assert.That(New_Code.Text == code, "Record found in last line as value are 1, first description, 100, Test Passed and going to edit it.");
        }

            public void Edit_Time_Record_Func(IWebDriver driver,string code,string description, string price)
        {
            Thread.Sleep(4000);
            IWebElement go_to_last_page_button1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            go_to_last_page_button1.Click();
            Thread.Sleep(4000);
            IWebElement New_Code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
           // Console.Write("\nValue found at last row is=>"); Console.Write(New_Code.Text);
            if (New_Code.Text == code)
            {
                //Console.WriteLine("\nRecord found in last line as value are 1, first description, 100, Test Passed and going to edit it.");

                IWebElement edit_button = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                edit_button.Click();

                IWebElement code_textbox_2 = driver.FindElement(By.Id("Code")); code_textbox_2.Clear();
                code_textbox_2.SendKeys(code);
                IWebElement description_textbox_2 = driver.FindElement(By.Id("description")); description_textbox_2.Clear();
                description_textbox_2.SendKeys(description);
                IWebElement price1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
                price1.Click();
                IWebElement price_textbox_2 = driver.FindElement(By.Id("Price"));
                price_textbox_2.Click();
                price_textbox_2.SendKeys(" ");
                price_textbox_2.SendKeys(price);

                IWebElement save_button = driver.FindElement(By.Id("SaveButton"));
                //Wait_Class.Wait_To_Be_Clickable(driver, "Id", "SaveButton", 20);
                save_button.Click();
                //Console.WriteLine("Records edited successfully, new values are 2, 2nd description, 200. Test passed.");
            }
            else
            {
                Console.WriteLine("Record as value 1,frirst description, 100 not found at last line, so no edit operation happens, Test failed.");
            }
        }

        public void Delete_Time_Record_Func(IWebDriver driver)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Now cursor entered into Delete_Time_Record_Func().");
            // Now delete the edited record
            //Got to last page
            Thread.Sleep(4000);
            //Wait_Class.Wait_To_Be_Clickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 20);
            IWebElement go_to_last_page_button2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            go_to_last_page_button2.Click();
            Thread.Sleep(4000);
            IWebElement newCode1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode1.Text == "2")
            {
                IWebElement delete_button = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                delete_button.Click();
                Console.WriteLine("Record foundat last line as are 2, 2nd description, 200. deleted successfully, Test Passed.");
            }
            else { Console.WriteLine("Record not found at last line as value are 2, 2nd description, 200, Test Failed."); }
        }
    }
}
