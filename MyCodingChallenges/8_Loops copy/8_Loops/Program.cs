

using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Your code here */

        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {
            int onlyOdd = 0;
            foreach(int y in x)
            {
                if (y % 2 == 1)
                {
                    onlyOdd++;
                }
            }
            return onlyOdd;

            throw new NotImplementedException("UseFor() is not implemented yet.");
        }

        /// <summary>
        /// This method counts the even entries from the provided List<object> 
        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {
             int onlyEven = 0;
             foreach (object y in x)
            {
                if (y is double || y is float || y is sbyte || y is byte || y is short ||
                y is ushort || y is long)
                {
                    if ((long)y % 2 == 0) onlyEven++;
                }
                else if (y is int)
                {
                    if ((int)y % 2 == 0) onlyEven++;
                }
                else if (y is uint)
                {
                    if ((uint)y % 2 == 0) onlyEven++;
                }
                else if (y is ulong)
                {
                    if ((ulong)y % 2 == 0) onlyEven++;
                }
            }
            return onlyEven;
            
            throw new NotImplementedException("UseForEach() is not implemented yet.");
        }

        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>. 
        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {
            int iterator = 0;
            int mult4 = 0;

            while (x[iterator] != 1234)
            {
                if (x[iterator] % 4 == 0)
                {
                    mult4++;
                }
                iterator++;
            }
            return mult4;
            
            throw new NotImplementedException("UseFor() is not implemented yet.");
            
        }

        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its 
        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {
            int threeFour = 0;
            for (int y = 0; y < x.Length; y++)
            {
                if (y % 3 == 0 && y % 4 == 0)
                {
                    threeFour++;
                }
            }
            return threeFour;
            
            throw new NotImplementedException("UseForThreeFour() is not implemented yet.");
        }

        /// <summary>
        /// This method takes an array of List<string>'s. 
        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {
           string catString = "";
            for (int y = 0; y < stringListArray.Length; y++)
            {
                foreach (string x in stringListArray[y])
                {
                    catString += (x + " ");
                }
            }
            return catString; 
            throw new NotImplementedException("LoopdyLoop() is not implemented yet.");
        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace _8_LoopsChallenge
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            /* Your code here */

//        }

//        /// <summary>
//        /// Return the number of elements in the List<int> that are odd.
//        /// </summary>
//        /// <param name="x"></param>
//        /// <returns></returns>
//        public static int UseFor(List<int> x)
//        {
//            throw new NotImplementedException("UseFor() is not implemented yet.");
//        }

//        /// <summary>
//        /// This method counts the even entries from the provided List<object> 
//        /// and returns the total number found.
//        /// </summary>
//        /// <param name="x"></param>
//        /// <returns></returns>
//        public static int UseForEach(List<object> x)
//        {
//            throw new NotImplementedException("UseForEach() is not implemented yet.");
//        }

//        /// <summary>
//        /// This method counts the multiples of 4 from the provided List<int>. 
//        /// Exit the loop when the integer 1234 is found.
//        /// Return the total number of multiples of 4.
//        /// </summary>
//        /// <param name="x"></param>
//        public static int UseWhile(List<int> x)
//        {
//            throw new NotImplementedException("UseFor() is not implemented yet.");
//        }

//        /// <summary>
//        /// This method will evaluate the Int Array provided and return how many of its 
//        /// values are multiples of 3 and 4.
//        /// </summary>
//        /// <param name="x"></param>
//        /// <returns></returns>
//        public static int UseForThreeFour(int[] x)
//        {
//            throw new NotImplementedException("UseForThreeFour() is not implemented yet.");
//        }

//        /// <summary>
//        /// This method takes an array of List<string>'s. 
//        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
//        /// </summary>
//        /// <param name="stringListArray"></param>
//        /// <returns></returns>
//        public static string LoopdyLoop(List<string>[] stringListArray)
//        {
//            throw new NotImplementedException("LoopdyLoop() is not implemented yet.");
//        }
//    }
//}