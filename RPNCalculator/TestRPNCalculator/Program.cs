﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPNCalculator;

namespace TestRPNCalculator
{
    class Program
    {
        static double answer;

        static bool TestValidOperations()
        {
           string equation = "1,2,+";
           bool success = Calculator.Evaluate(equation, out answer);
           return TestResult("1", "1 2 + input", "3", answer.ToString());
        }
        static bool TestInput()
        {
            string equation = "";
            bool success = Calculator.Evaluate(equation, out answer);
            string actual = success ? "TRUE" : "FALSE";
            return TestResult("1", "Empty input", "FALSE", actual.ToString());
        }

        static bool TestResult(string Id, string Description, string Expected, string Actual)
        {
            string passed = (Expected == Actual) ? "PASS" : "FAIL";
            Console.WriteLine($"{Id} | {Description} | {Expected} | {Actual} | {passed}");
            return passed == "PASS";

        }

        static void Main(string[] args)
        {
            bool AllTestsPassed = true;
            AllTestsPassed &= TestInput();
            AllTestsPassed &= TestValidOperations();

            Console.ReadKey();
        }
    }

}
