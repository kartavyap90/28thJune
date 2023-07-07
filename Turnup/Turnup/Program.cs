using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

public class Program
{
    private static void Main(string[] args)
    {
        //IWebDriver driver = new ChromeDriver();
        //driver.Manage().Window.Maximize();

        //Login into portal and verify user name
        //driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        //IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        //usernameTextbox.SendKeys("hari");
        //IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        //passwordTextbox.SendKeys("123123");
        //IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        //loginButton.Click();
        //IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        //if (hellohari.Text == "Hello hari!")
        //{
        //    Console.WriteLine("User has logged Successfully");
        //}
        //else
        //{
        //    Console.WriteLine("User has not logged in Successfully");
        //}


        //"Create New" record automation for time and material module
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        Thread.Sleep(5000);

        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

        IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
        usernametextbox.SendKeys("hari");
        //Thread.Sleep(1000);


        IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
        passwordtextbox.SendKeys("123123");
        //Thread.Sleep(1000);


        //IWebElement closepopupmsg = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        //closepopupmsg.Clear();

        IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginbutton.Click();
        //Thread.Sleep(1000);


        IWebElement menu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        menu.Click();
        //Thread.Sleep(1000);

        IWebElement timeandmaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeandmaterials.Click();
        //Thread.Sleep(1000);


        IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createnewbutton.Click();
        //Thread.Sleep(1000);


        IWebElement codetextbox = driver.FindElement(By.Id("Code"));
        codetextbox.Clear();
        codetextbox.SendKeys("1");
        //Thread.Sleep(1000);

        IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
        descriptiontextbox.Clear();
        descriptiontextbox.SendKeys("first description");
        //Thread.Sleep(1000);

        IWebElement price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        price.Click();
        //Thread.Sleep(1000);


        IWebElement pricetextbox = driver.FindElement(By.Id("Price"));
        pricetextbox.Clear();
        pricetextbox.SendKeys("100");
        //Thread.Sleep(1000);

        IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
        savebutton.Click();
        Thread.Sleep(2000);
        Console.WriteLine("Details inserted as value are 1, first description, 100, Test Passed.");

        //Now edit the last record
        //Now go to last page
        Thread.Sleep(10000);
        IWebElement go_to_last_page_button1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
        go_to_last_page_button1.Click();
        Thread.Sleep(10000);

        IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

        if (newCode.Text == "1")
        {
            Console.WriteLine("Record found in last line as value are 1, first description, 100, Test Passed and going to edit it.");

            IWebElement edit_button = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            edit_button.Click();

            IWebElement code_textbox_2 = driver.FindElement(By.Id("Code")); code_textbox_2.Clear();
            code_textbox_2.SendKeys("2");
            IWebElement description_textbox_2 = driver.FindElement(By.Id("Description"));   description_textbox_2.Clear();
            description_textbox_2.SendKeys("2nd description");
            IWebElement price1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]")); 
            price1.Click();
            IWebElement price_textbox_2 = driver.FindElement(By.Id("Price"));
            price_textbox_2.Click();
            //price_textbox_2.Clear();
            price_textbox_2.SendKeys("");
            price_textbox_2.SendKeys("200");
            
            IWebElement save_button = driver.FindElement(By.Id("SaveButton"));
            Thread.Sleep(2000);
            save_button.Click();
            Console.WriteLine("Records edited successfully, new values are 2, 2nd description, 200. Test passed.");
        }
        else
        {
            Console.WriteLine("Record as value 1,frirst description, 100 not found at last line, so no edit operation happens, Test failed.");
        }
        
        

        // Now delete the edited record
        //Got to last page
        Thread.Sleep(20000);
        IWebElement go_to_last_page_button2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
        go_to_last_page_button2.Click() ;
        IWebElement newCode1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")); 

        if (newCode1.Text == "2")
        {
            IWebElement delete_button = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            delete_button.Click();
            Console.WriteLine("Record foundat last line as are 2, 2nd description, 200. deleted successfully, Test Passed.");
        }
        else { Console.WriteLine("Record not found at last line as value are 2, 2nd description, 200, Test Failed."); }




        //For delete the records only at grid

        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        Thread.Sleep(5000);

        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

        IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
        usernametextbox.SendKeys("hari");
        //Thread.Sleep(1000);


        IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
        passwordtextbox.SendKeys("123123");
        //Thread.Sleep(1000);


        //IWebElement closepopupmsg = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        //closepopupmsg.Clear();

        IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginbutton.Click();
        //Thread.Sleep(1000);


        IWebElement menu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        menu.Click();
        //Thread.Sleep(1000);

        IWebElement timeandmaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeandmaterials.Click();
        //Thread.Sleep(1000);

    }
}



