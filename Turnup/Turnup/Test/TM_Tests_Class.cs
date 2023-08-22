using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnup.Pages;
using Turnup.Utilities;

namespace Turnup.Test
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests_Class : Common_Driver_Class
    {

        [SetUp]
        public void TM_Setup()
        {
            driver = new ChromeDriver();

            //Login Page object intialization and calling function of that class
            Login_Page_Class Login_Page_Obj = new Login_Page_Class();
            Login_Page_Obj.Login_Steps_Func(driver);


            //Home Page object intialization and calling functions of that class
            Home_Page_Class Home_Page_Obj = new Home_Page_Class();
            Home_Page_Obj.Go_To_TM_Page_Func(driver);

        }
        [Test, Order(1), Description("This test checks that user can able to create time and material record.")]
        public void Cerate_Time_And_Material_Record_Test()
        {
            //Time and Material Page object intializationa and calling functions of that class
            TM_Page_Class TM_Page_Obj = new TM_Page_Class();
            TM_Page_Obj.Create_Time_Record_Func(driver, "1","Description", "100");

        }
        [Test, Order(2), Description("This test checks that user can able to edit time and material record.")]
        public void Edit_Time_And_Material_Record_Test()
        {
            TM_Page_Class TM_Page_Obj = new TM_Page_Class();
            TM_Page_Obj.Edit_Time_Record_Func(driver, "1","2","Second Description", "200");
        }
        [Test, Order (3), Description("This test checks that user can able to delete time and material record.")]
        public void Delete_Time_And_Material_Record_Test()
        {
            TM_Page_Class TM_Page_Obj = new TM_Page_Class();
            TM_Page_Obj.Delete_Time_Record_Func(driver);
        }

        [TearDown]
        public void Closing_Steps()
        {
            driver.Quit();
        }
    }
}
