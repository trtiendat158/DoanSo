using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think in your mind about a number from 0 to 100.");
            int a = 0, b = 100;
            int count = 1;
            string answer;
            while (b > a + 1)
            {
                int c = (a + b) / 2;
                Console.WriteLine("Q{0}: Does your number greater than {1}?", count, c);
                count++;
                answer = Console.ReadLine();
                if (answer == "Y")
                {
                    a = c + 1;
                }
                if (answer == "N")
                {
                    b = c;
                }
            }
            Console.Write("Q{0}: Is your number {1}?", count, a);
            answer = Console.ReadLine();
            if (answer == "Y")
            {
                Console.WriteLine("Your number is "+a);
            }
            else if (answer =="N")
            {
                Console.WriteLine("Your number is" + b);
            }
        }
    }
}
