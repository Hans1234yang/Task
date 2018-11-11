using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.直接构造方法 new 一个task 对象

            Console.WriteLine("主线程开始执行");
            Task t1 = new Task(SayHi);        //参数是一个 Action 。 传一个方法就可以了
            t1.Start();
            Console.ReadLine();
        }

        //无参数，无返回值的方法
        static void SayHi()
        {
            Console.WriteLine("hello world");
        }
    }
}
