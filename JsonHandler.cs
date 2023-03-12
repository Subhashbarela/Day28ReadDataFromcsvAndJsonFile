using CsvHelper;
using Json.Net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Day28ProgramsUsingTPL
{
    public class JsonHandler
    {
        private static object serializer;

        public static void JsonDataHndling()
        {
            string ImpFilePath = "C:\\Users\\Shiva027\\Desktop\\BridgeLabSolution\\Day28ProgramsUsingTPL\\Day28ProgramsUsingTPL\\Utility\\Addresses.csv";
            string ExpFilePath = "C:\\Users\\Shiva027\\Desktop\\BridgeLabSolution\\Day28ProgramsUsingTPL\\Day28ProgramsUsingTPL\\Utility\\ExportJsonFile.json";

            using (var reader = new StreamReader(ImpFilePath))
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
                Console.WriteLine(" Read Data From Csv File And Write To Json File : ");
                Console.WriteLine("............................................");
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(ExpFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, record);
                    //foreach (AddressDetails ExpRecord in record)
                    //{
                    //    sr.Serialize(writer, ExpRecord);
                    //    Console.WriteLine("\n");
                    //}
                    //Console.WriteLine("\n");

                }
            }
        }
    }
}
