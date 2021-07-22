using System;
using System.IO;

namespace CSVUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("Please input the file path of the QuickBooks CSV:");
            //    var copyFromPath = Console.ReadLine();
            //    if(Path.IsPathFullyQualified(copyFromPath))
            //}

            Console.WriteLine("Please input the file path of the Teaplixx CSV:");
            var copyToPath = Console.ReadLine();

            Console.WriteLine("Please input the file path of where you want the new file to be located:");
            var newFileCreationPath = Console.ReadLine();
        }
    }
}
