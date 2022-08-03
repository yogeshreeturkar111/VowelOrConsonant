using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelConsonant
{
    public static class CheckVowel
    {
        public static void Check()
        {
            Console.WriteLine("Enter any Character");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a' ||ch=='e' ||ch=='i' ||ch=='o' ||ch=='u' ||
                ch == 'A' || ch == 'E' || ch =='I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is vowel");
            }
            else if((ch>='a' && ch<='z') || (ch>='A' && ch<='Z'))
            {
                Console.WriteLine(ch + " is consonant");
            }
        }

    }
}
