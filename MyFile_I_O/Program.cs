using System;
using System.IO;

namespace MyFile_I_O
{
    class program
    {
        static void Main(string[] args)
        {
                //to write a file use the "StreamWriter" object
                StreamWriter writer = new StreamWriter("Myfile.txt", true);
                //loop it!

                //string BevString = "This is a string of chars";

                //for (int i = 0; i < bevString.Length, i++)



                /*int interator = 1;
                foreach ( char c in BevString );

                StreamWriter writer = new StreamWriter ("MyFile.txt");
                */


                StreamReader reader = new StreamReader ("MyFile.txt");

                int i = 0;
                while (!reader.EndOfStream)
                {
                string str = reader.ReadLine();
                Console.WriteLine($"{i++} - {str}");
                
                }


        }
    }
}
