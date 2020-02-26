using System;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {

        }
    }

    public class Calculator
    {
        private double accumulator = 0;

        public double Accumulator { get; private set; }

        public void Clear()
        {
            accumulator = 0;
        }

        public double Add(double a, double b)
        {
            accumulator = a + b;
            return accumulator;
        }

        public double Add(double a)
        {
            accumulator += a;
            return accumulator;
        }

        public double Subtract(double a, double b)
        {
            accumulator = a - b;
            return accumulator;
        }

        public double Subtract(double a)
        {
            accumulator -= a;
            return accumulator;
        }

        public double Multiply(double a, double b)
        {
            accumulator = a * b;
            return accumulator;
        }

        public double Multiply(double Multiplier)
        {
            accumulator = accumulator * Multiplier;
            return accumulator;
        }

        public double Power(double x, double exp)
        {
            if (x < 0) throw new NumBeingRaisedToPowerUnderZero("First argument was negative.");
            return Math.Pow(x, exp);
        }

        public double Power(double exp)
        {
            if(Accumulator < 0) throw new NumBeingRaisedToPowerUnderZero(" First argument was negative");
            accumulator = Math.Pow(accumulator, exp);
            return accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b.Equals(0)) throw new DivideByZeroException();
            accumulator = a / b;
            return accumulator;
        }

        public double Divide(double divider)
        {
            if (divider.Equals(0)) throw new DivideByZeroException();
            accumulator = accumulator/divider;
            return accumulator;
        }
    }

    public class NumBeingRaisedToPowerUnderZero : Exception
    {
        public NumBeingRaisedToPowerUnderZero(string message)
            : base(message)
        { }
    }
}
