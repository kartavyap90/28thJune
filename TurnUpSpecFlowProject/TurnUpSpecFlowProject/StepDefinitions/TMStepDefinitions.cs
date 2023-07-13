using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using TurnUpSpecFlowProject.Pages;

namespace TurnUpSpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class TMStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        Login_Page_Class login_page_obj = new Login_Page_Class();
        Home_Page_Class home_page_obj = new Home_Page_Class();
        TM_Page_Class tm_page_obj = new TM_Page_Class();


        Wait_Class Wait_Obj = new Wait_Class();


        [Given(@"I log into TurnUp portal")]
        public void GivenILogIntoTurnUpPortal()
        {
            login_page_obj.Login_Steps_Func(driver);
        }


        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            home_page_obj.Go_To_TM_Page_Func(driver);
        }

        [When(@"I create a new Time and Material record '([^']*)' '([^']*)' '([^']*)'")]
        
        public void WhenICreateANewTimeAndMaterialRecord(string code, string description, string price)
        {
            tm_page_obj.Create_Time_Record_Func(driver, code, description, price);
        }


        [When(@"I edit a new Time and Material record '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenIEditANewTimeAndMaterialRecord(string code, string description, string price)
        {
            tm_page_obj.Edit_Time_Record_Func(driver, code, description, price);

        }


        [Then(@"The record should be saved '([^']*)'")]
        public void ThenTheRecordShouldBeSaved(string code)
        {
            tm_page_obj.AssertCreateTimeRecord(driver, code);
        }


       
        
        

    }
}