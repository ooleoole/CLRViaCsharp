﻿using System;
using System.Runtime.InteropServices;
using CLRViaCsharp.CharEncoding;
using CLRViaCsharp.ExplicitlyImplementingEvents;
using CLRViaCsharp.Indexer;

namespace CLRViaCsharp
{
    class Program
    {
        public delegate int Test(string hej);
        static void Main(string[] args)
        {

            var indexer = new IndexerTest();

            int X(int a, int b) => a * b;
            var ol = X(8, 4);
          
            Test del = x => x == "hej" ? 1 : 2;
            Test y = (b) => b == "hej" ? 1 : 2;
            //del.Invoke("asd");
            //Console.WriteLine(indexer[4]);
            //Console.ReadKey();

            //Console.WriteLine(indexer[4]);
            //Console.WriteLine(indexer['t']);
            //Console.WriteLine(indexer['k']);

            //var pro = new Processor();
            //var dist = new Distributor(pro);
            //var manager = new Manager(pro);

            //pro.Process();
            var lotsOfEventsType= new LotsOfEventsType();
            var respondeToEvent = new ListenToEvent(lotsOfEventsType);
            lotsOfEventsType.ImDoingIt();
            var stringEncoder = new StringEncoder();
            var encodedString = stringEncoder.Encoder("hej");
            foreach (var bt in encodedString)
            {
                Console.Write(bt);
            }
            Console.WriteLine();
            var decodedString = stringEncoder.Decoder(encodedString);
            Console.WriteLine(decodedString);
            Console.ReadKey();
        }


    }
}
