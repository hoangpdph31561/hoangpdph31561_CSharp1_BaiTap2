using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal static class HamTao
    {
        public static string GetInput(string msg)
        {
            Console.WriteLine($"Mời bạn nhập {msg}");
            return Console.ReadLine();
        }
        public static string GetInputWithRegex(string msg,string regex)
        {
            string input;
            do
            {
                input = GetInput(msg);
                if (!Regex.IsMatch(input, regex))
                {
                    Console.WriteLine($"Bạn nhập không thỏa mãn regex của {msg}");
                    Console.WriteLine("Xin mời nhập lại");
                }
            } while (!Regex.IsMatch(input, regex));
            return input;
        }
        public static bool CheckCount(ArrayList lst)
        {
            if(lst.Count == 0)
            {
                Console.WriteLine("Danh sách không có đối tượng");
                return false;
            }
            return true;
        }
    }
}
