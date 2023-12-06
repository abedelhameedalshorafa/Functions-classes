using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///// part 1 /////

            //DateTime date1 = new DateTime(2019, 6, 14);
            //DateTime date2 = new DateTime(2019, 6, 20);

            //int result1 = getDays(date1, date2);
            //Console.WriteLine(result1);


            ///// part 2 /////


            //string[] numInStr = { "1a", "a", "2232b", "b" };
            //string[] newArray = getStringArraysWithNumbers(numInStr);
            //foreach(string neww in newArray)
            //{
            //    Console.WriteLine($"{neww}");
            //}


            ///// part 3 /////

            //string sentence = "One two three four";

            //Console.WriteLine(reverseOdd(sentence));


            ///// part 4 /////

            Console.WriteLine(IsPandigital(9814072356)); 
            Console.WriteLine(IsPandigital(123456789));



        }


        static bool IsPandigital(long number)
        {
            string numberString = number.ToString();
            HashSet<char> digits = new HashSet<char>();

            foreach (char digit in numberString)
            {
                if (char.GetNumericValue( digit) >= 0 && char.GetNumericValue( digit) <= 9)
                {
                    digits.Add(digit);
                }
            }

            return digits.Count == 10;
        }

        static string reverseOdd(string sentence)
        {
            string[] arrSentence = sentence.Split(' ');
            for(int i=0;i<arrSentence.Length;i++)
            {
                if (arrSentence[i].Length%2==1)
                {
                    char[] charArray = arrSentence[i].ToCharArray();
                    Array.Reverse(charArray);
                    arrSentence[i] = new string(charArray);
                }
            }
            return string.Join(" ", arrSentence);
        }

        static string[] getStringArraysWithNumbers(string[] numInStr)
        {
            int count = 0;
            foreach (string str in numInStr)
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (str.Contains(Convert.ToString(i)))
                    {
                        count++;
                    }
                }

            }

            string[] newArray = new string[count];
            int j = 0;

            foreach (string str in numInStr)
            {
                for(int i =0;i<=9;i++)
                {
                    if (str.Contains($"{i}"))
                    {
                        newArray[j] = str;
                        j++;
                        break;
                    }
                }
                
            }
            return newArray;
        }

        static int getDays(DateTime date1,DateTime date2)
        {
            // .Days -> integers Days
            // .totalDays-> double days
            TimeSpan timeDeffernce = date2 - date1;
            int numOfDays = Convert.ToInt32( timeDeffernce.TotalDays);
            return numOfDays;
        }
    }
}
