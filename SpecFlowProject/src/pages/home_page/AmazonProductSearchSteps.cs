using OpenQA.Selenium;
using SpecFlowProject.src;
using SpecFlowProject.src.pages.home_page;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowProject.src.pages.home_page
{
    [Binding]
    class AmazonProductSearchSteps
    {
        private  IWebDriver driver;
        private BrowserFactory browserFactory;
        public static AmazonSearch amazon;
        private AmazonProductSearchValidation amazonProductSearchValidation;

        public AmazonProductSearchSteps()
        {
            amazon = new AmazonSearch();
            amazonProductSearchValidation = new AmazonProductSearchValidation();
        }


        [Given("Launch The Application and Navigate to URL")]
        public void LaunchTheApplicationAndNavigateURL()
        {
            browserFactory = new BrowserFactory();
            driver = browserFactory.SelectBrowseForExecution();
            browserFactory.LoadApplication(driver, "https://www.amazon.in");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
        }

        [When("When i search the (.*)")]
        public void SearchIphone(string product)
        {
           amazon.SearchIphone(driver,product);
        }



        [Then(@"Iphone product is displayed")]
        public void ThenIphoneProductIsDisplayed()
        {
            amazonProductSearchValidation.IsIPhoneSearched(driver);
        }


        [Then("click on product and Retrieve the Price of Product")]
        public void ThenTheResultShouldBe()
        {
            Console.WriteLine("Passed");
            browserFactory = new BrowserFactory();
            browserFactory.CloseAllDrivers(driver);
        }



        // Scenario 2
        [When(@"Check the Products (.*) and check the details with respect")]
        public void WhenCheckTheProductsAndCheckTheDetailsWithRespectIPhone(String Product)
        {
            amazon.SearchIphone(driver,"ksjhks");
        }


        [Then(@"Tear Down the Application")]
        public void ThenTearDownTheApplication()
        {
            Console.WriteLine("Passed");
            browserFactory = new BrowserFactory();
            browserFactory.CloseAllDrivers(driver);
        }

        public static void Main(string[] args)
        {
        }

    }
}
