﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
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

        [TestCase(3, 2, 5)]
        [TestCase(2, 1, 3)]
        [TestCase(-5,5, 0)]
        public void AddAppend_Test_Success(double a, double b, double expectedResult)
        {
            _uut.Add(b);
            Assert.That(_uut.Add(a), Is.EqualTo(expectedResult));
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

        [TestCase(2,3,-5)]
        [TestCase(1, 2, -3)]
        [TestCase(-6, 6, 0)]
        public void SubtractingAppend_Test_Success(double a, double b, double expectedResult)
        {
            _uut.Subtract(a);
            Assert.That(_uut.Subtract(b), Is.EqualTo(expectedResult));
        }
        [TestCase(2, 3, 8)]
        [TestCase(2, -4, 0.0625)]
        [TestCase(2, 0, 1)]
        public void Power_Test_Success(double a, double b, double exptectedResult)
        {
            Assert.That(_uut.Power(a,b),Is.EqualTo(exptectedResult));
        }

        [Test]
        public void Divide_Test_Exception()
        {
            Assert.That(() => _uut.Divide(2, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(4, 2)]
        [TestCase(-4, 2)]
        [TestCase(4, -2)]
        [TestCase(-4, -2)]
        public void Divide_Test_Success(int a, int b)
        {
            Assert.That(() => _uut.Divide(a, b), Is.EqualTo(a/b));
        }

        [Test]
        public void DivideOverload_Test_Exception()
        {
            Assert.That(() =>_uut.Divide(0),Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(2, 0)]
        public void OverLoadMultiply_MultiBy2_Expect0(double multiplier1, double expected)
        {
            _uut.Multiply(multiplier1);
            Assert.That(_uut.Accumulator, Is.EqualTo(expected));
        }

        [TestCase(5, 5)]
        [TestCase(-5, -5)]
        [TestCase(0, 0)]
        public void OverloadMultiply_StartAt1_Success(double a, double expected)
        {
            _uut.Add(1);
            Assert.That(_uut.Multiply(a), Is.EqualTo(expected));
        }

        [TestCase(2,0.5)]
        [TestCase(5, 0.2)]
        [TestCase(10,0.1)]
        public void OverloadDivide_StartAt1_test(double divider, double expected)
        {
            _uut.Add(0,1);
            Assert.That(_uut.Divide(divider),Is.EqualTo(expected));
        }

        [TestCase(5, 2, 0)]
        [TestCase(-5, 7, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(3, 0, 0)]
        public void Clear_Test_Success(double a, double b, double expectedResult)
        {
            _uut.Add(a, b);
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Power_ExceptionTest_Success()
        {
            Assert.That(() => _uut.Power(-1, 1), Throws.TypeOf<NumBeingRaisedToPowerUnderZero>());
        }

        [Test]
        public void Power_Overload_Success()
        {
            _uut.Divide(2, 2);
            Assert.That(() => _uut.Power(2), Is.EqualTo(Math.Pow(1, 2)));
        }
        
        [Test]
        public void Power_Overload_Exception_Thrown()
        {
            _uut.Subtract(1, 2);
            Assert.That(() => _uut.Power(2), Throws.TypeOf<NumBeingRaisedToPowerUnderZero>());
        }
    }
}
