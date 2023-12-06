using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask5
{
    class myClass
    {
        public myClass()
        {
            Console.WriteLine("MyClass class has initialized!");
        }

        public void helloAll(string name) 
        {
            Console.WriteLine($"Hello All, I am {name}");
        }

        public int CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        public void SortArray(int[] array)
        {
            Array.Sort(array);
        }

        public void CalculateDifference(DateTime startDate, DateTime endDate)
        {
            TimeSpan difference = endDate - startDate;

            int years = endDate.Year - startDate.Year;
            int months = endDate.Month - startDate.Month;
            int days = endDate.Day - startDate.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(startDate.Year, startDate.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Difference: {years} years, {months} months, {days} days.");
        }

        public DateTime ConvertToDate(string dateString)
        {
            string format = "dd-MM-yyyy";
            DateTime resultDate = DateTime.ParseExact(dateString, format, System.Globalization.CultureInfo.InvariantCulture);
            return resultDate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ///// part 1 ////
            
            myClass obj1 = new myClass();

            ///// part 2 /////
            ///
            obj1.helloAll("Abedelhameed");

            ///// part 3 /////
            ///
            int result = obj1.CalculateFactorial(5);
            Console.WriteLine($"Factorial of 5: {result}");

            ///// part 4 /////
            ///
            int[] array = { 11, -2, 4, 35, 0, 8, -9 };
            obj1.SortArray(array);
            Console.Write("sorted array is: ");
            for(int i=0;i<array.Length;i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            ///// part 5 /////
            ///
            DateTime date1 = new DateTime(1981, 11, 03);
            DateTime date2 = new DateTime(2013, 09, 04);

            obj1.CalculateDifference(date1, date2);

            ///// part 6 /////
            ///
            string dateString = "12-08-2004";

            DateTime convertedDate = obj1.ConvertToDate(dateString);

            Console.WriteLine($"Converted Date: {convertedDate:yyyy-MM-dd}");
        }
    }
}
