using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDifinitions
{
    [Binding]
    public sealed class Practice
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [When(@"Users Entered Credentials")]
        public void GivenIHaveEnteredIntoTheCalculator(Table table)
        {
            var dictionary = TableExtension.ToDictionary(table);
            var test = dictionary["UserName"];
            Console.WriteLine(test);
            Console.WriteLine(dictionary["Password"]);

  
        }


         
        internal class TableExtension {
            public static Dictionary<String, String> ToDictionary(Table table) {
                var dictionary = new Dictionary<String, String>();
                foreach (var row in table.Rows) {
                    dictionary.Add(row[0], row[1]);
                }
                return dictionary;
            }
        } }
}
