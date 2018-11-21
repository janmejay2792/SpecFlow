using OpenQA.Selenium;

namespace SpecFlowProject.src.pages.home_page
{
    class AmazonSearch
    {
        IWebDriver driver;

        public AmazonSearch(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SearchIphone(string product)
        {
            driver.FindElement(AmazonProductSearchElements.AmazonHomePageSearchBox).SendKeys(product);
            driver.FindElement(AmazonProductSearchElements.SerachButton).Click();
        }
    }
}
