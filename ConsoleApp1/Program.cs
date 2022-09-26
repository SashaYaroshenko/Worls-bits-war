using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.BitsWar(new List<int> { 7, -3, 20 });
        }
    }

    public static class Kata
    {
        public static string BitsWar(List<int> numbers)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            int sum_odd = 0;
            int sum_even = 0;
            string res = "";

            odd = numbers.FindAll(x => x % 2 != 0);
            even = numbers.FindAll(x => x % 2 == 0);

            countOnes(ref odd);
            countOnes(ref even);

            sum_odd = odd.Sum();
            sum_even = even.Sum();

            if(sum_odd > sum_even)
            {
                res = "odds win";
            }
            else if(sum_odd < sum_even)
            {
                res = "evens win";
            }
            else
            {
                res = "tie";
            }
            return res;
        }
        static void countOnes(ref List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int a = list[i];
                string str;
                if (a >= 0)
                {
                    str = Convert.ToString(a, 2);
                    a = str.Count(x => x == '1');
                }
                else
                {
                    a = Math.Abs(a);
                    str = Convert.ToString(a, 2);
                    a = str.Count(x => x == '1');
                    a = -a;
                }
                list[i] = a;
            }
        }
    }
}
