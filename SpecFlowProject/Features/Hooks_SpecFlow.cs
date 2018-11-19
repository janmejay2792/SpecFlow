using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Features
{
    [Binding]
    public sealed class Hooks_SpecFlow
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before Scenario executed");
        }

        [BeforeStep]
        public void BeforeStep()
        {
            Console.WriteLine("Before Step executed");
        }



        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Scenario executed");
        }
    }
}
