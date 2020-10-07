using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число на проверку палиндромности: ");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                int number = result;
                Console.WriteLine(IsPalindrome(number));
            }
            else
            {
                Console.WriteLine("Ввели не число");
            }
            Console.ReadKey();
        }

        static bool IsPalindrome(int number)
        {
            if (number >= 0 && number < 10)
                return true;
            int numberLength = GetLength(number);
            int[] digits = new int[numberLength];

            for (int i = numberLength - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
                Console.WriteLine(digits[i]);
            }

            for (int i = 0; i < numberLength / 2; i++)
            {
                
                if (digits[i] != digits[numberLength - i - 1])
                {
                    return false;
                }
            }
            
            return true;
            
        }

        static int GetLength(int number)
        {
            int n = 0;
            while (number > 0)
            {
                number /= 10;
                n++;
            }
            return n;
        }
    }
}
