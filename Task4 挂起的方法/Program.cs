using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_挂起的方法
{
    class Program
    {
        //线程挂起的方法  task.waitAll()   先等待哪个线程执行完毕，再个
        static void Main(string[] args)
        {
            Task t1 = new Task
               (
                () => { Console.WriteLine("任务1开始");Console.WriteLine("任务1结束");}
                );
            Task t2 = new Task
                (
                () => { Console.WriteLine("任务2开始");Console.WriteLine("任务2结束"); }
                );

            Task t3 = new Task
                (
                () => { Console.WriteLine("先等前2个任务搞定");Task.WaitAll(t1, t2);Console.WriteLine("任务3执行结束");}
                );

            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
