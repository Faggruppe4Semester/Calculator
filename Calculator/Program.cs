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
        public double Accumulator { get; private set; } = 0;

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Add(double a)
        {
            Accumulator += a;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Subtract(double a)
        {
            Accumulator -= a;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double Multiplier)
        {
            Accumulator = Accumulator * Multiplier;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            if (x < 0) throw new NumBeingRaisedToPowerUnderZero("First argument was negative.");
            return Math.Pow(x, exp);
        }

        public double Power(double exp)
        {
            if(Accumulator < 0) throw new NumBeingRaisedToPowerUnderZero(" First argument was negative");
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b.Equals(0)) throw new DivideByZeroException();
            Accumulator = a / b;
            return Accumulator;
        }

        public double Divide(double divider)
        {
            if (divider.Equals(0)) throw new DivideByZeroException();
            Accumulator = Accumulator/divider;
            return Accumulator;
        }
    }

    public class NumBeingRaisedToPowerUnderZero : Exception
    {
        public NumBeingRaisedToPowerUnderZero()
        { }

        public NumBeingRaisedToPowerUnderZero(string message)
            : base(message)
        { }

        public NumBeingRaisedToPowerUnderZero(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
