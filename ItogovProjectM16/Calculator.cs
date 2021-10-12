// <copyright file="Calculator.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItogovProjectM16
{
    /// <summary>
    /// Класс Calculator
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Метод Сложение
        /// </summary>
        /// <param name="a">Ввод первого числа</param>
        /// <param name="b">Ввод второго числа</param>
        /// <returns> результат сложения </returns>
        public int Additional(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Метод разности
        /// </summary>
        /// <param name="a">Ввод первого числа</param>
        /// <param name="b">Ввод второго числа</param>
        /// <returns> результат разности </returns>
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Метод умножения
        /// </summary>
        /// <param name="a">Ввод первого числа</param>
        /// <param name="b">Ввод второго числа</param>
        /// <returns>результат умножения</returns>
        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Метод деления
        /// </summary>
        /// <param name="a">Ввод первого числа</param>
        /// <param name="b">Ввод второго числа</param>
        /// <returns>результат деления</returns>
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
