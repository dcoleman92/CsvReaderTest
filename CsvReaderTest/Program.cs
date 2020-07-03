using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsvReaderTest
{
    class Program
    {
        static void Main(string[] args)
        {



            using (var reader = new StreamReader(@"C:\CsvReaderTest\MOCK_DATA.csv"))
            {
                List<string> headerList = null;
                List<string> endCSV = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    endCSV.Add(line);
                    if (headerList == null)
                    {
                        headerList = line.Split(',').ToList();
                    }
                    else
                    {
                        var values = line.Split(',');
                        for (int i = 0; i < headerList.Count; i++)
                        {
                            Console.WriteLine(headerList[i] + "=" +  " " + values[i]);
                        }
                        Console.WriteLine();
                    }
                }

            }
            Console.ReadLine();
        }
 

    }

}
