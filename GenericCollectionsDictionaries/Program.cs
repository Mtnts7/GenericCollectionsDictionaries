using System;
using System.Collections.Generic;

namespace GenericCollectionsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> plakalar = new MyDictionary<int, string>();
            plakalar.Add(35, "İzmir");
            plakalar.Add(41, "Kocaeli");
            plakalar.Add(06, "Ankara");
            plakalar.Add(34, "İstanbul");

            Console.WriteLine(plakalar.Mam1[0] + ":" + plakalar.Mam2[0]);
            Console.WriteLine(plakalar.Mam1[1] + ":" + plakalar.Mam2[1]);
            Console.WriteLine(plakalar.Mam1[2] + ":" + plakalar.Mam2[2]);
            Console.WriteLine(plakalar.Mam1[3] + ":" + plakalar.Mam2[3]);
        }
        
    }
    
}
