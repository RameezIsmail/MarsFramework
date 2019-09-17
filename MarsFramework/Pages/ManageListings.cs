using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {


        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//a[@href='/Home/ListingManagement']")]
        private IWebElement manageListingsButton { get; set; }

        //Click on active slider
        [FindsBy(How = How.XPath, Using= "(//input[contains(@name,'isActive')])[1]")]
        private IWebElement ActiveSlider { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "(//i[contains(@class,'remove icon')])[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement clickActionsButton { get; set; }

        internal void EditListings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\Users\Rammy\Desktop\marsframework\MarsFramework\ExcelData\TestDataManageListings.xlsx", "ManageListings");

            GlobalDefinitions.wait(10);

            manageListingsButton.Click();

            edit.Click();

        }

        internal void Listings()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\Users\Rammy\Desktop\marsframework\MarsFramework\ExcelData\TestDataManageListings.xlsx", "ManageListings");


            GlobalDefinitions.wait(10);

            manageListingsButton.Click();


                view.Click();

                Base.Back();

                ActiveSlider.Click();

                delete.Click();

                clickActionsButton.Click();
            

        }

    }
}
