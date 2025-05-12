using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._4._2___
{
    class Expression
    {
        private double a, b, c, d;

        public Expression() { a = 0; b = 0; c = 0; d = 0; }
        public Expression(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b; 
            this.c = c; 
            this.d = d;
        }
        public Expression(Expression other)
        {
            this.a = other.a;
            this.b = other.b;
            this.c = other.c;
            this.d = other.d;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public double evaluate() 
        {
            //Sqrt qwe = new Sqrt();
            //double calculate = qwe.SqrtCalculate(c, d);
            //double result = (1 + a - b / 2) / (calculate + a / b);
            double result = (1 + a - b / 2) / (Sqrt.SqrtCalculate(c,d) + a / b);

            if (b == 0) throw new InvalidOperationException("Division by 0");
            if ((24 + d - c) <= 0) throw new InvalidOperationException("The radical expression is less than 0");
            if ((Math.Sqrt(24 + d - c) + a / b) == 0) throw new InvalidOperationException("Division by 0");
            return result;
        }
    }
}
