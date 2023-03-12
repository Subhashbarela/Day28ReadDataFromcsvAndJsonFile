using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day28ProgramsUsingTPL
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read Data From Csv File and Write To Json File :");
            JsonHandler.JsonDataHndling();
            Console.ReadLine();
        }
    }
}
