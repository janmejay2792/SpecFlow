using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
    class AmazonProductSearchElements
    {
        
        public static By AmazonHomePageSearchBox = By.XPath("//*[@id='twotabsearchtextbox']");
        public static By SerachButton = By.XPath("//*[@value='Go']");
     
    }
}
