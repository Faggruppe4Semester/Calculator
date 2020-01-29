﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator.Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator.Calculator();
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, -4, -1)]
        [TestCase(-1, -1, -2)]
        public void Add_Test_Success(double a, double b, double expectedResult)
        {
            Assert.That(_uut.Add(a,b), Is.EqualTo(expectedResult));
        }

        [TestCase(1, 2, 2)]
        [TestCase(-2, 3, -6)]
        [TestCase(-4, -5, 20)]
        public void Multiply_Test_Success(double a, double b, double expectedResult)
        {
            Assert.That(_uut.Multiply(a,b),Is.EqualTo(expectedResult));
        }

        [TestCase(2, 3, -1)]
        [TestCase(2, -2, 4)]
        [TestCase(-2, -2, 0)]
        public void Subtracting_Test_Success(double a, double b, double expectedResult)
        {
            Assert.That(_uut.Subtract(a,b),Is.EqualTo(expectedResult));
        }

        [TestCase(2, 3, 8)]
        [TestCase(2, 4, 16)]
        [TestCase(2, 0, 1)]
        public void Power_Test_Success(double a, double b, double exptectedResult)
        {
            Assert.That(_uut.Power(a,b),Is.EqualTo(exptectedResult));
        }


        [TestCase(5, 2, 0)]
        [TestCase(-5, 7, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(3, 0, 0)]
        public void Clear_Test_Success(double a, double b, double expectedResult)
        {
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(expectedResult));
        }
        /*[Test]
        public void Divide_Test_Throw()
        {
            DivideByZeroException Exceotion = Assert.Throws<DivideByZeroException>(_uut.Divide(2, 0));
            Assert.Throws(_uut.Divide(2, 0), );
        }*/
    }


}
