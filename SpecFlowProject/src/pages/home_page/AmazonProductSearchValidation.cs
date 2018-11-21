using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.src.pages.home_page
{
    class AmazonProductSearchValidation
    {

        public void IsIPhoneSearched(IWebDriver driver)
        {
            var listOfProduct = driver.FindElements(AmazonProductSearchElements.IphoneTitle);

            Assert.True(listOfProduct[0].Text.Contains("Apple iPhone"), "Iphone is not Displayed");
        }
    }
}
