using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一线1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task
                (
                () => { Run1(); }   //在lambda后面  加方法
                );
            Task t2 = Task.Factory.StartNew
                (
                () => { Run2(); }   //在lambda后面  加方法
                );

            t1.Start();
           
            Console.ReadLine();

            //任务2比 任务1 执行的 快，因为工厂 快创建
        }

        static void Run1()
        {
            Console.WriteLine("我是任务1");
        }
        static void Run2()
        {
            Console.WriteLine("我是任务2");
        }
    }
}
