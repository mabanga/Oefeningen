using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class RemoveStringWhiteSpacedemo
    {
        public static void RemoveSpaceUsingForEach()
        {
            const string str = "csharp is a programming language";
            var chars = str.ToCharArray();
            var str1 = string.Empty;
            foreach (var eachChar in chars)
            {
                if (eachChar != ' ')
                {
                    str1 += eachChar;
                }
            }
            Console.WriteLine(str1);
        }
    }
}
