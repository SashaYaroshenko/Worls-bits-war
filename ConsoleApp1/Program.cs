using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.BitsWar(new List<int> { 1, 5, 12 });
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
            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]%2 == 0)
                {
                    even.Add(numbers[i]);
                }
                else
                {
                    odd.Add(numbers[i]);
                }
            }
            for(int i = 0; i < odd.Count; i++)
            {
                if(odd[i]<0)
                {
                    odd[i] = Convert.ToInt32(Convert.ToString(odd[i], 2)) * (-1);
                }
                else
                {
                    odd[i] = Convert.ToInt32(Convert.ToString(odd[i], 2));
                }
                
            }
            for (int i = 0; i < even.Count; i++)
            {
                if (even[i]<0)
                {
                    even[i] = Convert.ToInt32(Convert.ToString(even[i], 2)) * (-1);
                }
                else
                {
                    even[i] = Convert.ToInt32(Convert.ToString(even[i], 2));
                }
                
            }
            for(int i = 0; i < odd.Count; i++)
            {
                sum_odd += odd[i];
            }
            for(int i = 0; i < even.Count; i++)
            {
                sum_even+=even[i];
            }
            if(sum_odd > sum_even)
            {
                res+="odds win";
            }
            else if(sum_odd < sum_even)
            {
                res+= "evens win";
            }
            else
            {
                res += "tie";
            }
            return res;
        }
    }
}
