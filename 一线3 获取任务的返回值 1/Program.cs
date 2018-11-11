using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一线3_获取任务的返回值_1
{
    class Program
    {
        //3.获取任务的返回值 1
        static void Main(string[] args)
        {
            Task<List<string>> t1 = Task.Factory.StartNew<List<string>>    //该任务有返回值，返回值为list<string>
                (
                   () => { return Run1(); }
                );
            t1.Wait(); //挂起线程   t1 返回值是 一个列表

            Task t2 = Task.Factory.StartNew
                (
                () => { Console.WriteLine("集合中有"+string.Join(", ",t1.Result)); }
                
                );
            Console.ReadLine();
        }

        //返回一个list列表 类型是string 
        static List<string> Run1()
        {
            return new List<string> { "1","4","8"};
        }
    }
}
