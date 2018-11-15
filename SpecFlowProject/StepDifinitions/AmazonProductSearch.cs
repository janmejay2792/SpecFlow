using OpenQA.Selenium;
using SpecFlowProject.src;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;


namespace SpecFlowProject
{
    [Binding]
    public sealed class AmazonProductSearch
    {
        private IWebDriver driver;
        private BrowserFactory browserFactory;
        private PageElement pageObject;

        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("Launch The Application and Navigate to URL")]
        public void LaunchTheApplicationAndNavigateURL()
        {
            browserFactory = new BrowserFactory();
            this.driver = browserFactory.SelectBrowseForExecution();
            browserFactory.LoadApplication(driver, "https://www.amazon.in");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
        }

        [When("Check the Title page and put all the links in list")]
        public void checkTitlePageAndStoreLinksInList()
        {

            //Assert.Equals("Amazon", this.driver.FindElement(By.XPath("//span[text()='Amazon']")).Text);
            // Search the product in EditBox
            pageObject = new PageElement();
            System.Threading.Thread.Sleep(4000);
            pageObject.DictionaryObject(driver, "AmazonSearchEditBox").SendKeys("Iphone");
            pageObject.DictionaryObject(driver, "SerachButton").Click();

            ICollection<IWebElement> links = driver.FindElements(By.TagName("a"));



            foreach (IWebElement link in links)
            {
                if (link.GetAttribute("innerText").SequenceEqual("Apple iPhone"))
                {

                    Console.WriteLine(link.Text.ToString());
                    Console.ReadLine();
                    link.Click();
                    this.driver.Navigate().Back();
                    System.Threading.Thread.Sleep(1000);

                }
            }
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
            pageObject = new PageElement();
            System.Threading.Thread.Sleep(4000);
             
            // Adding Scenario Context Flow
            ScenarioContext.Current.Add("ProductName", Product);
            var ProductName = ScenarioContext.Current.Get<String>("ProductName");
            pageObject.DictionaryObject(driver, "AmazonSearchEditBox").SendKeys(ProductName);
            pageObject.DictionaryObject(driver, "SerachButton").Click();
        }


        [Then(@"Tear Down the Application")]
        public void ThenTearDownTheApplication()
        {
            Console.WriteLine("Passed");
            browserFactory = new BrowserFactory();
            browserFactory.CloseAllDrivers(driver);
        }



    }

   



    



}
