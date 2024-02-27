using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongCommonPrefix
{
    internal class Program
    {
        //https://leetcode.com/problems/longest-common-prefix/description/
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));
            Console.ReadKey();
        }

        static string LongestCommonPrefix(string[] strs)
        {
            int f = 1;
            string res = "";
            try
            {
                for (int i = 0; i < strs[0].Length; i++)
                {
                    while (f < strs.Length)
                    {
                        if (strs[0][i] == strs[f][i])
                            f++;
                        else return res;
                    }
                    res += strs[0][i];
                    f = 0;
                }
                return res;
            }
            catch
            {
                return res;
            }
        }

    }
}
