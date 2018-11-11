using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_taskfactory实例开启
{
    class Program
    {
        //6.taskfactory 实例开启
        static void Main(string[] args)
        {
            TaskFactory tf1 = new TaskFactory();
            Task t1 = tf1.StartNew(SayHi);
            Console.ReadLine();
        }
        static void SayHi()
        {
            Console.WriteLine("Hello world");
        }
    }
}
