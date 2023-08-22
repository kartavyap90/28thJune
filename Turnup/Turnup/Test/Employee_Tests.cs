using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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
    public class Employee_Tests : Common_Driver_Class
    {
        
        [SetUp]
        public void Employee_Setup()
        {
            driver = new ChromeDriver();
            Login_Page_Class Login_page_Obj = new Login_Page_Class();
            Login_page_Obj.Login_Steps_Func(driver);

            Home_Page_Class Home_Page_Obj = new Home_Page_Class();
            Home_Page_Obj.Go_To_Employee_Page_Func(driver);
        }

        [Test, Order(1), Description("This test check that user can create the employee details.")]
        public void Create_Employee_Test()
        {
            Employee_Page_Class Emp_Page_Obj = new Employee_Page_Class();
            Emp_Page_Obj.Create_Employee(driver);
        }

        [Test, Order(2), Description("This test check that user can edit the employee details.")]
        public void Edit_Employee_Test()
        {
            Employee_Page_Class Emp_Page_Obj = new Employee_Page_Class();
            Emp_Page_Obj.Edit_Employee(driver);
        }

        [Test, Order(3), Description("This test check that user can delete the employee details.")]
        public void Delete_Employee_Test()
        {
            Employee_Page_Class Emp_Page_Obj = new Employee_Page_Class();
            Emp_Page_Obj.Delete_Employee(driver);
        }
    }
}
