using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {

        //2. 用factory.startNew  不仅是1. new  一个start 也是 2.调用strat 方法，合二为一 
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(Fangfa1);
            Console.ReadLine();
        }

        static void Fangfa1()
        {
            Console.WriteLine("hello wrold");
        }
    }
}
