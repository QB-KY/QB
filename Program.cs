using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入班级：");
            String strclass = Console.ReadLine();
            Console.WriteLine("请输入学号：");
            String number = Console.ReadLine();
            Console.WriteLine("请输入姓名：");
            String name = Console.ReadLine();
            Console.WriteLine("你是{0}班的{1}号{2}",strclass,number,name);
        }
    }
}
