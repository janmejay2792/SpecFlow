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
        private IWebDriver driver;
        private BrowserFactory browserFactory;
        private AmazonSearch amazon;

        public AmazonProductSearchSteps()
        {
            amazon = new AmazonSearch(driver);
        }

        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef



        [Given("Launch The Application and Navigate to URL")]
        public void LaunchTheApplicationAndNavigateURL()
        {
            browserFactory = new BrowserFactory();
            this.driver = browserFactory.SelectBrowseForExecution();
            browserFactory.LoadApplication(driver, "https://www.amazon.in");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
        }

        [When("When i search the (.*)")]
        public void SearchIphone(string product)
        {
            amazon.SearchIphone(product);
        }



        [Then(@"Iphone product is displayed")]
        public void ThenIphoneProductIsDisplayed()
        {
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
            amazon.SearchIphone("ksjhks");
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
