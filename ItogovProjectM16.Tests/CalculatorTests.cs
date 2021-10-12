// <copyright file="CalculatorTests.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using NUnit.Framework;

namespace ItogovProjectM16.Tests
{
    /// <summary>
    /// Класс для проверки работы методов класса Calculator
    /// </summary>
    [TestFixture]
    public class CalculatorTests
    {
        /// <summary>
        /// Метод проверки операции разности
        /// </summary>
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }

        /// <summary>
        /// Метод проверки операции сложения
        /// </summary>
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(300, 10) == 310);
        }

        /// <summary>
        /// Метод проверки операции умножения
        /// </summary>
        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(30, 10) == 300);
        }

        /// <summary>
        /// Метод проверки операции деления
        /// </summary>
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(300, 10) == 30);
        }
    }
}
