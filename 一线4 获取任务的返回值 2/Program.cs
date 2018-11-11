using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一线4_获取任务的返回值_2
{
    class Program
    {
        //获取任务的返回值
        static void Main(string[] args)
        {
            //该任务的返回类型是 string类型 的列表
            Task<List<string>> t1 = Task.Factory.StartNew<List<string>>
                (
                  () => { return Run1(); }
                );



            //在 wait方法 等待一个 任务 时，有可能 会阻塞线程， 为了解决这个问题 ，我们可以使用ContinueWith方法
            // 这能在一个任务完成时自动启动一个新的任务来 处理执行结果
            var t2 = t1.ContinueWith(
                (i)=> { Console.WriteLine("集合中的个数"+string.Join(",",i.Result)); }
                
                );

            Console.ReadLine();
        }

        //返回类型 string类型的 列表
        static List<string> Run1()
        {
            return new List<string> { "1","4","8"};
        }
    }
}
