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
        public IWebDriver driver;
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("Launch The Application and Navigate to URL")]
        public void LaunchTheApplicationAndNavigateURL()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
            System.Threading.Thread.Sleep(20000);
            driver.FindElement(By.XPath("//*[@id='twotabsearchtextbox']")).SendKeys("Iphone");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@value='submit']")).Click();


        }

        [When("Check the Title page and put all the links in list")]
        public void checkTitlePageAndStoreLinksInList()
        {
            //IWebDriver driver;
            
            //Assert.Equals("Amazon", driver.FindElement(By.XPath("//span[text()='Amazon']")).Text);

            
           
            
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            Console.WriteLine("Passed");
        }
    }
}
