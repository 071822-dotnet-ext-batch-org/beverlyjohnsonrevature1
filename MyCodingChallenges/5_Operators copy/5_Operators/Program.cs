﻿using System;

namespace _5_OperatorsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("THis is a test");

            int increment = 0;
            increment++;

            Console.WriteLine("num is {0}", increment);
            Console.WriteLine("num is {0}", increment++);
        }

        /// <summary>
        /// This method takes an in and returns the int incremented once
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Increment(int num)
        {
            int r = ++num;
            return r;

            throw new NotImplementedException($"Increment() is not implemented yet.");
        }

        /// <summary>
        /// This method takes an int and returns the int decremented once
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Decrement(int num)
        {
            int r = --num;
            return r;

            throw new NotImplementedException($"Decrement() is not implemented yet");
        }

        /// <summary>
        /// This method takes a boolean value and returns the opposite boolean value.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool Not(bool input)
        {
            bool r = !input;
            return r;

            throw new NotImplementedException($"Not() is not implemented yet");
        }

        /// <summary>
        /// /// This method takes an int and returns the negative of that int.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Negate(int num)
        {
            int r = -num;
            return r;
            
            throw new NotImplementedException($"Negate() is not implemented yet");

        }

        /// <summary>
        /// This method takes two ints and returns the sum
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Sum(int num1, int num2)
        {
            int Sum = num1 + num2;
            return Sum; 

            
            throw new NotImplementedException($"Sum() is not implemented yet");
        }

        /// <summary>
        /// This method takes two ints and returns the difference
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Diff(int num1, int num2)
        {
            int Diff = num1 - num2;
            return Diff;
            throw new NotImplementedException($"Diff() is not implemented yet");
        }

        /// <summary>
        /// This method takes two ints and returns the product 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Product(int num1, int num2)
        {
            int Product = num1 * num2;
            return Product;

            throw new NotImplementedException($"Product() is not implemented yet");
        }

        /// <summary>
        /// This method takes two ints and returns the quotient
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Quotient(int num1, int num2)
        {
            return num1 / num2;
             

            throw new NotImplementedException($"Quotient() is not implemented yet");
        }

        /// <summary>
        /// This method returns the remainder.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Remainder(int num1, int num2)
        {
            int Remainder = num1 % num2;
            return Remainder;
            
            throw new NotImplementedException($"Remainder() is not implemented yet");
        }

        /// <summary>
        /// This method takes two ints and returns true if the first value is greater
        /// or equal to the second value, otherwise false.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="!"></param>
        /// <returns></returns>
        public static bool And(int num1, int num2)
        {
            return (num1 != 0 && num1 > num2);

            throw new NotImplementedException($"And() is not implemented yet");
        }

        /// <summary>
        /// This method takes two ints and returns true if num1 is
        /// greater than num2 or if num1 is greater than zero. Otherwise, false.
        /// </summary>
        /// <param name="num1"></param>
        /// <returns></returns>
        public static bool Or(int num1, int num2)
        {
            return (num1 == num2 || num1 < 0);
            
            throw new NotImplementedException($"Or() is not implemented yet");
        }
    }
}