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
        private PageValidation _pageValidation;

        public AmazonProductSearch(IWebDriver driver)
        {
            this.driver = driver;
            _pageValidation = new PageValidation();
        }

        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("Launch The Application and Navigate to URL")]
        public void LaunchTheApplicationAndNavigateURL()
        {
            browserFactory = new BrowserFactory();
            driver = browserFactory.SelectBrowseForExecution();
            browserFactory.LoadApplication(driver,"https://www.amazon.in");
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

            var links = driver.FindElements(By.TagName("a"));
            foreach (var link in links)
            {
                if (link.GetAttribute("innerText").SequenceEqual("Apple iPhone")) {
                    Console.WriteLine(link.Text.ToString());
                    link.Click();
                    _pageValidation.IsPageDisplayed(link.GetAttribute("innerText"));
                    this.driver.Navigate().Back();
                    System.Threading.Thread.Sleep(1000);

                }
            }
        }

        [Then("click on product and Retrieve the Price of Product")]
        public void ThenTheResultShouldBe()
        {
            Console.WriteLine("Passed"); 
            browserFactory.CloseAllDrivers(driver);
        }
    }
}
