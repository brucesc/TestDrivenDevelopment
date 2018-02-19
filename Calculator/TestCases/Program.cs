using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxTechnicalTraining.Bootcamp.DotNET.TestDrivenDevelopment;


namespace TestCases
{
    class Program
    {
       
        static void Main(string[] args)
        {
           bool allTestsPassed = TestForZeroInputs();
            allTestsPassed &= TestForOneInput();
            allTestsPassed &= TestForValidInputs();
            allTestsPassed &= TestForMoreThanTenInputs();


            if (allTestsPassed)
            {
                Console.WriteLine("All tests passed.");
            }
            else
            {
                Console.WriteLine("Some tests failed");

            }

            Console.ReadKey();

        }
        static bool TestForValidInputs()
        {
            string userInput = "3, 5";
            Calculator calculator = new Calculator();
            int sum = calculator.Add(userInput);
            bool passed = PrintTestResult("3", "Test for valid inputs", "8", sum.ToString());
            userInput = "9, 21";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("4", "Test for valid inputs", "30", sum.ToString());
            // three inputs
            userInput = "3, 8, 12";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("5", "Test for valid inputs", "23", sum.ToString());

            userInput = "9, 21, 10";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("6", "Test for valid inputs", "40", sum.ToString());

            userInput = "6611, 3878, 2670";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("7", "Test for valid inputs", "13159", sum.ToString());
            // four inputs
            userInput = "9, 21, 10, 10";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("8", "Test for valid inputs", "50", sum.ToString());
            // five inputs
            userInput = "9, 21, 10, 10, 10";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("9", "Test for valid inputs", "60", sum.ToString());
            // six inputs
            userInput = "9, 21, 10, 10, 10, 10";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("10", "Test for valid inputs", "70", sum.ToString());
            // seven inputs
            userInput = "9, 21, 10, 10, 10, 10, 10";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("11", "Test for valid inputs", "80", sum.ToString());
            // eight inputs
            userInput = "9, 21, 10, 10, 10, 10, 10, 10";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("12", "Test for valid inputs", "90", sum.ToString());
            // nine inputs
            userInput = "9, 21, 10, 10, 10, 10, 10, 10, 10";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("13", "Test for valid inputs", "100", sum.ToString());
            // ten inputs
            userInput = "9, 21, 10, 10, 10, 10, 10, 10, 10, 10";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("14", "Test for valid inputs", "110", sum.ToString());


            return passed;


        }
        static bool TestForMoreThanTenInputs()
        {
            // Console.WriteLine("Enter one integer then press enter.");
            string userInput = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11"; //Console.ReadLine();
            string ApplicationExceptionThrown = "No Exception";
            Calculator calculator = new Calculator();
            try
            {
                // should throw an ApplicationException
                calculator.Add(userInput);
            }
            catch (ApplicationException ex)
            {
                ApplicationExceptionThrown = "ApplicationException";
            }
            bool passed = PrintTestResult("15", "Test for more than ten inputs", "ApplicationException", ApplicationExceptionThrown);
            return passed;
        }

        static bool TestForOneInput()
        {
            // Console.WriteLine("Enter one integer then press enter.");
            string userInput = "100"; //Console.ReadLine();
            string ApplicationExceptionThrown = "No Exception";
            Calculator calculator = new Calculator();
            try
            {
                // should throw an ApplicationException
                calculator.Add(userInput);
            }
            catch (ApplicationException ex)
            {
                ApplicationExceptionThrown = "ApplicationException";
            }
            bool passed = PrintTestResult("2", "Test for one input", "ApplicationException", ApplicationExceptionThrown);
            return passed;
        }
        static bool TestForZeroInputs()
        {
            //Console.WriteLine("Enter integers separated by commas then press enter.");
            string userInput = ""; //Console.ReadLine();
            string ApplicationExceptionThrown = "No Exception";
            Calculator calculator = new Calculator();
            try
            {
                // should throw an ApplicationException
                calculator.Add(userInput);
            }
            catch (ApplicationException ex)
            {
                ApplicationExceptionThrown = "ApplicationException";
            }
            bool passed = PrintTestResult("1", "Test for zero inputs", "ApplicationException", ApplicationExceptionThrown);
            return passed;
        }
        static bool PrintTestResult(string Id, string Description, string ExpectedResults, string ActualResults)
        {
            string passfail = ExpectedResults == ActualResults ? "PASS" : "FAIL"; // Tenary operator

            Console.WriteLine($"{Id} {Description} {ExpectedResults} {ActualResults} {passfail}");
            return passfail == "PASS";

        }
    }
}
