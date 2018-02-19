using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    public class Calculator
    {
        public static bool Evaluate(string equation, out double answer)
        {
            answer = 0.0;
            if (equation.Length == 0)
            {
                return false;
            }
            Stack<double> theStack = new Stack<double>();
            string[] operands = equation.Split(',');
            foreach (string oper in operands)
            {
                if (oper == "+")
                {
                    double op1 = theStack.Pop(); // get the first thing off the stack
                    double op2 = theStack.Pop(); // get the second thing off the stack
                    double ans = op1 + op2;
                    theStack.Push(ans);
                }
                else if (oper == "-")
                {
                    double op2 = theStack.Pop(); // get the first thing off the stack
                    double op1 = theStack.Pop(); // get the second thing off the stack
                    double ans = op1 - op2;
                    theStack.Push(ans);
                }
                else if (oper == "*")
                {
                    double op1 = theStack.Pop(); // get the first thing off the stack
                    double op2 = theStack.Pop(); // get the second thing off the stack
                    double ans = op1 * op2;
                    theStack.Push(ans);
                }
                else if (oper == "/")
                {
                    double op2 = theStack.Pop(); // get the first thing off the stack
                    double op1 = theStack.Pop(); // get the second thing off the stack
                    double ans = op1 / op2;
                    theStack.Push(ans);

                }
                else // if the next char is a number put it on the stack
                {
                    double nbr = double.Parse(oper);
                    theStack.Push(nbr);
                }
            }
            answer = theStack.Pop();

            return true;
        }
    }
}
