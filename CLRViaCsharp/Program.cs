using System;
using CLRViaCsharp.Events;
using CLRViaCsharp.Indexer;

namespace CLRViaCsharp
{
    class Program
    {
        public delegate int Test(string hej);
        static void Main(string[] args)
        {

            var indexer = new IndexerTest();

            Test del = x => x == "hej" ? 1 : 2;
            Test y = (b) => b == "hej" ? 1 : 2;
            //del.Invoke("asd");
            //Console.WriteLine(indexer[4]);
            //Console.ReadKey();

            //Console.WriteLine(indexer[4]);
            //Console.WriteLine(indexer['t']);
            //Console.WriteLine(indexer['k']);

            var pro = new Processor();
            var dist = new Distributor(pro);
            var manager = new Manager(pro);
            
            pro.Process();
            Console.ReadKey();
        }


    }
}
