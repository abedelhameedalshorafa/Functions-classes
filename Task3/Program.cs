using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///// part 1 /////

            Console.WriteLine("the addition of numbers is : " + add(5, 4));


            ///// part 2 /////

            Console.WriteLine(removeLeadingTrailing("00402"));


            ///// part 3 /////
            
            
            //int[] numbers = { 25, 143, 89, 13, 105 };
            //Console.WriteLine($"the second largest number : {secondLargestNumber(numbers)}");


            ///// part 4 /////

            Console.WriteLine(isRepdigit(-5));


            ///// part 5 /////

            
            Console.WriteLine(reverseWords("the sky is blue"));


            ///// part 6 /////

            //int[] numbers = {2, 55, 60, 97, 86};
            //Console.WriteLine(sevenBoom(numbers));

            ///// part 7 /////

            Console.WriteLine(InsertWhitespace("SheWalksToTheBeach"));


            ///// part 8 /////

            bool[] flags = { true, false, false, true, false };
            Console.WriteLine("the count of true : "+countTrue(flags));


            ///// part 9 /////

            Console.WriteLine(capToFront("hApPy"));


            ///// part 10 /////

            string[] strings = { "rsq", "6hi", "g", "rsq6hig" };
            Console.WriteLine(matchLastItem(strings));

            ///// part 11 /////

            Console.WriteLine(FindNaN(new double[] { 1, 2, double.NaN }));
            Console.WriteLine(FindNaN(new double[] { double.NaN, 1, 2, 3, 4 }));  
            Console.WriteLine(FindNaN(new double[] { 0, 1, 2, 3, 4 }));

            ///// part 12 /////

            int[] result1 = RemoveDuplicates(new int[] { 1, 0, 3, 4,3 });
            Console.WriteLine(string.Join(", ", result1)); 

            string[] result2 = RemoveDuplicates(new string[] { "The", "big", "cat" });
            Console.WriteLine(string.Join(", ", result2)); 

            string[] result3 = RemoveDuplicates(new string[] { "John", "Taylor", "John" });
            Console.WriteLine(string.Join(", ", result3));

            ///// part 13 /////

            Console.WriteLine(ConvertTime("07:05:45PM"));
            Console.WriteLine(ConvertTime("12:40:22AM"));
            Console.WriteLine(ConvertTime("12:45:54PM"));

            ///// part 14 /////

            Console.WriteLine(RemoveLastVowel("Those who dare to fail miserably can achieve greatly."));

            ///// part 15 /////

            double[] numbers = { 3, 4, 5 };
            Console.WriteLine(sumOfCubes(numbers));


        }


        static double sumOfCubes(double[] numbers)
        {
            double sum = 0;
            for(int i=0;i<numbers.Length;i++)
            {
                sum += (Math.Pow(numbers[i], 3));
            }
            return sum;
        }

        static string RemoveLastVowel(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = RemoveLastVowelFromWord(words[i]);
            }

            return string.Join(" ", words);
        }

        static string RemoveLastVowelFromWord(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int lastVowelIndex = -1;

            // Find the index of the last vowel in the word
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (Array.IndexOf(vowels, word[i]) != -1)
                {
                    lastVowelIndex = i;
                    break;
                }
            }

            // Remove the last vowel from the word
            return lastVowelIndex != -1
                ? word.Remove(lastVowelIndex, 1)
                : word;
        }



        //static string RemoveLastVowel(string sentence)
        //{
        //    string[] words = sentence.Split(' ');
        //    for(int i=0;i<words.Length;i++)
        //    {
        //        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        //        bool flag = false;
        //        int index = -1;

        //        for (int j = words[i].Length-1;j>=0;j--)
        //        {
        //            if (vowels.Contains(words[i][j]))
        //            {
        //                flag = true;
        //                index = j;
        //                break;
        //            }
        //        }
        //        if(flag)
        //        {
        //            words[i].Remove(index, 1);
        //        }
        //    }
        //    return string.Join(" ", words);
        //}

        static string ConvertTime(string time12hr)
        {
            if (DateTime.TryParse(time12hr,out DateTime result))
            {
                return result.ToString("HH:mm:ss");
            }
            else
            {
                return "Invalid time format";
            }
        }

        static T[] RemoveDuplicates<T>(T[] arr)
        {
            int newSize = 0;
            
            
            for (int i = 0; i < arr.Length; i++)
            {
                //if (Array.IndexOf(arr, arr[i], 0, newSize) == -1)
                //{
                //    arr[newSize] = arr[i];
                //    newSize++;
                //}
                bool flag = true;
                for (int j=0;j<newSize;j++)
                {
                    if (arr[j].Equals(arr[i]))
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    arr[newSize] = arr[i];
                    newSize++;
                }
            }
            T[] result = new T[newSize];
            Array.Copy(arr, result, newSize);

            return result;
        }

        static int FindNaN(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (double.IsNaN(arr[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        static bool matchLastItem(string[] words)
        {
            string toCheck = string.Empty;
            for(int i=0;i<words.Length-1;i++)
            {
                toCheck += words[i];
            }
            return toCheck == words[words.Length - 1];
        }

        static string capToFront(string strings)
        {
            string result = string.Empty;
            string upperStr = string.Empty;
            string lowerStr = string.Empty;
            foreach(char c in strings)
            {
                if(char.IsUpper(c))
                {
                    upperStr += c; ;
                }
                else if(char.IsLower(c))
                {
                    lowerStr += c;
                }
            }
            result = upperStr + lowerStr;
            return result;
        }

        static int countTrue(bool[] flags)
        {
            int count = 0;
            foreach(bool flag in flags )
            {
                if(flag==true)
                {
                    count++;
                }
            }
            return count;
        }

        static string InsertWhitespace(string input)
        {
            string result = string.Empty;
            result += input[0];
            for (int i = 1; i < input.Length; i++)
            {
                char currentChar = input[i];
                char previousChar = input[i - 1];

                if (char.IsUpper(currentChar) && char.IsLower(previousChar))
                {
                    result += ' ';
                }

                result += currentChar;
            }

            return result.ToString();
        }

        static string sevenBoom(int[] numbers )
        {
            if (numbers.Contains(7))
                return "Boom";
            else
                return "there is no 7 in the array";
        }

        static string reverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        static bool isRepdigit(int number)
        {
            if (number >= 0)
            {
                return true;
            }
            else
                return false;
        }
        static int secondLargestNumber(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[numbers.Length - 2];
        }

        static double removeLeadingTrailing(string number)
        {
            double.TryParse(number, out double result);
            return result;
        }
        static int add(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
