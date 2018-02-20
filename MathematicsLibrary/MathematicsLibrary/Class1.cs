using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class Class1
    {
        public double Add(double a, double b)
        {
            //throw new NotImplementedException();
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            //throw new NotImplementedException();
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            //throw new NotImplementedException();
            return a * b;
        }
        
        public double Divide(double a, double b)
        {
            //throw new NotImplementedException();
            return a / b;
        }

        public double Square(double a)
        {
            //throw new NotImplementedException();
            return a * a;
        }

        public double Inverse(double a)
        {
            //throw new NotImplementedException();
            return 1 / a;
        }

        public double Negate(double a)
        {
            //throw new NotImplementedException();
            return a * -1;
        }

        public double Absolute(double a)
        {
            //throw new NotImplementedException();
            Class1 c = new Class1();

            if (a < 0)
            {
                return c.Negate(a);
            }
            else
            {
                return a;
            }
        }

        public double SquareRoot(double a)
        {
            throw new NotImplementedException();
        }
    }
}
