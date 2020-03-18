using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1._1
{
    class calculator
    {
        public int a;
        public int b;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public void add()
        {
            Console.WriteLine("这两个数的和：{0}", a + b);
        }
        public void subtraction()
        {
            Console.WriteLine("这两个数的差为：{0}", a - b);
        }
        public void multiplication()
        {
            Console.WriteLine("这两个数的积为：{0}", a * b);
        }
        public void division()
        {
            while (b == 0)
            {
                Console.WriteLine("除数不能为0");
                Console.WriteLine("请重新输入第二个整数:");
                b = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("这两个数的商为：{0}", a / b);
        }
        public void explain()
        {
            Console.WriteLine("请输入需要用的操作的序号");
            Console.WriteLine("1：加法");
            Console.WriteLine("2：减法");
            Console.WriteLine("3：乘法");
            Console.WriteLine("4：除法");
        }
        public void Equals(int a, int b)
        {
            if (a == b)
                Console.WriteLine("这两个数相等");
            else
                Console.WriteLine("这两个数不相等");
        }
    }
}
