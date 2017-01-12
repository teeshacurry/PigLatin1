using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pig Latin Translator");

            int repeat = 100;
            for (int i = 0; i < repeat; i++)
            {

                string vowel = "AEIOUaeiou";
            string myString = Console.ReadLine();



            char firstLetter = myString[0];
            char secondLetter = myString[1];

                if (vowel.Contains(firstLetter.ToString()))
                {
                    Console.WriteLine($"{myString}way");
                }
                else if (vowel.Contains(secondLetter.ToString()) && !vowel.Contains(firstLetter.ToString()))

                {
                    string smallString = myString.Substring(1);
                    Console.WriteLine($"{smallString}{firstLetter}ay"); // mystring.Substring


                }

                else if (!vowel.Contains(firstLetter.ToString()) && !vowel.Contains(secondLetter.ToString()))
                {
                    string bigString = myString.Substring(2);
                    Console.WriteLine($"{bigString}{firstLetter}{secondLetter}ay");
                }


            }
        }
    }
}      
    

