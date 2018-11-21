using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;

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

        // System.Assist.Dynamic flow Remove the dependency
        [When(@"Users Entered Login Credentials")]
        public void WhenUsersEnteredLoginCredentials(Table table)
        {
            IEnumerable<dynamic> details = table.CreateDynamicSet();
            foreach (var emp in details) {
                Console.WriteLine(emp.Key);
                Console.WriteLine(emp.value);
               
            }

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
