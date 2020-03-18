using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1._1
{
    class zifuchaun
    {
        string s1;
        string s2;

        public string S1 { get => s1; set => s1 = value; }
        public string S2 { get => s2; set => s2 = value; }

        public void explain2()
        {
            Console.WriteLine("请输入需要用的操作的序号");
            Console.WriteLine("1：加法");
            Console.WriteLine("2：减法");
        }

        public void zfcjia()
        {
            string z = string.Concat(s1, s2);
            Console.WriteLine("这两个字符相加为：{0}", z);
        }
        public void zfcjian()
        {
            foreach (Char s2s2 in s2)
            {
                s1 = s1.Replace(s2, "");
            }
            Console.WriteLine("这两个字符相减为：{0}", s1);
        }
    }
}
