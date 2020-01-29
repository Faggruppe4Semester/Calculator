﻿using System;

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
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Power(double x, double exp) => Math.Pow(x, exp);

        public double Divide(double a, double b)
        {
            if (b.Equals(0)) throw new DivideByZeroException();
            return a / b;
        }
    }
}
