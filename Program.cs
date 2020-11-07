using System;
using System.Collections.Generic;
using System.Linq;



namespace Week_9___Bitwise.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Q19toQ26(99, "remove");

            Console.WriteLine(BitParity(110011));
            
        }

        static void Q19toQ26(int number, string action) {

            string binary = Convert.ToString((long)number,2);
            int length = binary.Length;

            Console.WriteLine(binary, "This is your number in binary form"); // Easier to understand results

            if(action.ToLower() == "get") {

                Console.WriteLine(binary[length-1]); // Rightmost bit (Q19)

                Console.WriteLine(binary.Substring(length - 3)); // 3 rightmost bits (Q20)

                Console.WriteLine(binary[0]); // Leftmost bit (Q21)

                Console.WriteLine(binary.Substring(0,3)); // 3 leftmost bits (Q22)

            } else if(action.ToLower() == "remove") {

                Console.WriteLine(binary.Substring(0, length-1)); // Rightmost bit (Q19)

                Console.WriteLine(binary.Substring(0, length - 3)); // 3 rightmost bits (Q20)

                Console.WriteLine(binary.Substring(1, length-1)); // Leftmost bit (Q21)

                Console.WriteLine(binary.Substring(2, length-1)); // 3 leftmost bits (Q22)

            } else {
                Console.WriteLine("The action you want to run is invalid, please try again");
            }  
        }

        static string getBits(int x, int n, int p) {
            string binary = Convert.ToString(x);
            return binary.Substring(p-1, n);
        }

        private static int BitParity(int num)
        {
            string binary = Convert.ToString(num, 2);

            List<char> Ones = binary.Where(val => val == '1').ToList();

            return Ones.Count();
        }

        // I will try and do the other BIOs for Monday's lesson, I'm just trying to figure a better way of relating the alphabet to the base

    }
}