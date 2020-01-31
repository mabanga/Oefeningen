using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int count = 1, len = 0;
            Console.WriteLine("Enter a string: ");
            str = Console.ReadLine();
            while (len<=str.Length-1)
            {
                if (str[len]==' ' || str[len]=='\n' || str[len]=='\t')
                {
                    count++;
                }
                len++;
            }
            Console.WriteLine($"Total worsds : {count}");
            int countSpace = 0;
            foreach (char item in str)
            {
                if (item== ' ')
                {
                    countSpace++;
                }
            }
            Console.WriteLine($"Total spaces : {countSpace}");

            RemoveStringWhiteSpacedemo.RemoveSpaceUsingForEach();




            Console.ReadKey();
        }

    }
}
