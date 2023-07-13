using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using Turnup.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        //Login Page object intialization and calling function of that class
        Login_Page_Class Login_Page_Obj = new Login_Page_Class();
        Login_Page_Obj.Login_Steps_Func(driver);


        //Home Page object intialization and calling functions of that class
        Home_Page_Class Home_Page_Obj = new Home_Page_Class();
        Home_Page_Obj.Go_To_TM_Page_Func(driver);

        //Time and Material Page object intializationa and calling functions of that class
        TM_Page_Class TM_Page_Obj = new TM_Page_Class();
        TM_Page_Obj.Create_Time_Record_Func(driver);
        TM_Page_Obj.Edit_Time_Record_Func(driver);
        TM_Page_Obj.Delete_Time_Record_Func(driver);


    }
}



