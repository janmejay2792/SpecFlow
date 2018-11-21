using OpenQA.Selenium;

namespace SpecFlowProject.src.pages.home_page
{
    class AmazonSearch
    {
           

        public void SearchIphone(IWebDriver driver, string product)
        {
            driver.FindElement(AmazonProductSearchElements.AmazonHomePageSearchBox).SendKeys(product);
            driver.FindElement(AmazonProductSearchElements.SerachButton).Click();
        }
    }
}
