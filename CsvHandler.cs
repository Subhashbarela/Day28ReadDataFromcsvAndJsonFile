using CsvHelper;
using System;
using CsvHelper.Configuration;
using CsvHelper.Expressions;
using CsvHelper.TypeConversion;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day28ProgramsUsingTPL
{
    public class CsvHandler
    {
        public static void CSVDataHndling()
        {
            string ImpFilePath = "C:\\Users\\Shiva027\\Desktop\\BridgeLabSolution\\Day28ProgramsUsingTPL\\Day28ProgramsUsingTPL\\Utility\\Addresses.csv";
            string ExpFilePath = "C:\\Users\\Shiva027\\Desktop\\BridgeLabSolution\\Day28ProgramsUsingTPL\\Day28ProgramsUsingTPL\\Utility\\CsvExport.csv";

            using(var reader =new StreamReader(ImpFilePath))
           using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var record = csv.GetRecords<AddressDetails>().ToList();
                Console.WriteLine("Data read successfully fron csv file \n");
                foreach (AddressDetails addrDetails in record)
                {
                    Console.Write("\t" + addrDetails.firstName);
                    Console.Write("\t" + addrDetails.lastName);
                    Console.Write("\t" + addrDetails.address);
                    Console.Write("\t" + addrDetails.city);
                    Console.Write("\t" + addrDetails.state);
                    Console.Write("\t" + addrDetails.phoneNumber);
                    Console.WriteLine("\n");
                }
                Console.WriteLine(" Read Data From Csv File And Write To Other Csv File : ");
                Console.WriteLine("............................................");
                using (var writer = new StreamWriter(ExpFilePath))
                using (var Exprtcsv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    foreach(AddressDetails ExpRecord in record)
                    {
                        Exprtcsv.WriteRecord(ExpRecord);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("\n");

                }
            }
        }
    }
}
