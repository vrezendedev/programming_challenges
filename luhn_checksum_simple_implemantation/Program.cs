using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //The Luhn Checksum Formula... very simple implemantation
        static void Main(string[] args)
        {
            string number;
            char[] nums;
            int sum;

            bool mult;

            sum = 0;

            number = Console.ReadLine();
            nums = number.ToCharArray();

            if(nums.Length % 2 == 0) //if the array length is an even number, it shall start multiplying
            {
                mult = true;
            }
            else //if the array length is an odd number, it shall start not multiplying
            {
                mult = false;
            }

            for(int i = 0; i < nums.Length - 1; i++)
            {
                int digit = int.Parse(nums[i].ToString());

                if (mult == true) 
                {
                    digit = digit * 2;
                    
                    if(digit > 10)
                    {
                        digit = 1 + (digit % 10);
                    }
                }

                if(mult == true)
                {
                    mult = false;
                }
                else
                {
                    mult = true;
                }

                sum = sum + digit;
            }

            int checkdigit = int.Parse(nums[nums.Length - 1].ToString());

            if((sum + checkdigit) % 10 == 0)
            {
                Console.WriteLine("Valid number!");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

            Console.ReadKey();
        }
    }
}
