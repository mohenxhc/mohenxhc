using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("以下是整除加减乘除运算:");
            calculator ca = new calculator();
            Console.WriteLine("请输入第一个整数:");
            Int32 a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个整数:");
            Int32 b = Convert.ToInt32(Console.ReadLine());
            ca.B = b; ca.A = a;
            ca.Equals(a, b);
            ca.explain();
            Int32 s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {
                case 1: ca.add(); break;
                case 2: ca.subtraction(); break;
                case 3: ca.multiplication(); break;
                case 4: ca.division(); break;
            }

            Console.WriteLine("");
            Console.WriteLine("以下是字符串相加减:");
            Console.WriteLine("请输入第一个字符串:");
            string s1 = Console.ReadLine();
            Console.WriteLine("请输入第二个字符串:");
            string s2 = Console.ReadLine();

            zifuchaun zfc = new zifuchaun();
            zfc.S1 = s1;
            zfc.S2 = s2;

            zfc.explain2();
            Int32 t = Convert.ToInt32(Console.ReadLine());
            switch (t)
            {
                case 1: zfc.zfcjia(); break;
                case 2: zfc.zfcjian(); break;
                
            }

        }
    }
}
