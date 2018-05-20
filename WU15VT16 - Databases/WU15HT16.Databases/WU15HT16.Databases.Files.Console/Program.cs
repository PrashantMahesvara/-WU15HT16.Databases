using System;
using System.IO;

namespace WU15HT16.Databases.FilesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseDirectoryPath = Directory.GetCurrentDirectory() + @"..\..\..\";
            var dataDirectoryPath = Path.Combine(baseDirectoryPath, "Data");
            var filePath = Path.Combine(dataDirectoryPath, "Information.txt");

            Console.ReadLine();

            Directory.CreateDirectory(dataDirectoryPath);

            StreamWriter streamWriter = File.CreateText(filePath);
            streamWriter.Close();

            //streamWriter = new StreamWriter(filePath);
            //streamWriter.WriteLine("{0}: {1}", DateTime.Now, "Cancer!");
            //streamWriter.Close();

            //streamWriter = File.AppendText(filePath);
            //streamWriter.WriteLine("{0}: {1}", DateTime.Now, "MORE AIDS!");
            //streamWriter.Close();

            MemoryStream memoryStream = new MemoryStream();
            streamWriter = new StreamWriter(memoryStream);

            Console.ReadLine();
        }
    }
}
