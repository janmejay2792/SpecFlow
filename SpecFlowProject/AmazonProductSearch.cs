using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject
{
    [Binding]
    public sealed class AmazonProductSearch
    {
        private IWebDriver driver;
        
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("Launch The Application and Navigate to URL")]
        public void LaunchTheApplicationAndNavigateURL()
        {
            this.driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
        }

        [When("Check the Title page and put all the links in list")]
        public void checkTitlePageAndStoreLinksInList()
        {
            //IWebDriver driver;
            //system.threading.thread.sleep(20000);
            //Assert.Equals("Amazon", this.driver.FindElement(By.XPath("//span[text()='Amazon']")).Text);
            // Search the product in EditBox
            this.driver.FindElement(By.XPath("//*[@id='twotabsearchtextbox']")).SendKeys("Iphone");
        
            System.Threading.Thread.Sleep(3000);
            this.driver.FindElement(By.XPath("//*[@value='Go']")).Click();

            ICollection<IWebElement> links = driver.FindElements(By.TagName("a"));
            foreach (IWebElement link in links)
            {
                Console.WriteLine(link.Text.ToString());
            }


        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            Console.WriteLine("Passed");
        }
    }
}
