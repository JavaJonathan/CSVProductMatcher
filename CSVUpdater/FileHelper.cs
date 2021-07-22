using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVUpdater
{
    class FileHelper
    {
        public static List<QuickBooksProduct> GetCopyFromRecords(string filePath)
        {
            List<QuickBooksProduct> quickbooksProducts;
            using (var reader = new StreamReader(@"C:\Users\jonat\Documents\ProductsForRez\RezTest2.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    quickbooksProducts = csv.GetRecords<QuickBooksProduct>().ToList();
                    quickbooksProducts.ForEach(record => Console.WriteLine($"{record.ItemName} {record.ItemDescription}"));
                }
            }
            return quickbooksProducts;
        }

        public static List<TplxProduct> GetCopyToRecords(string filePath)
        {
            List<TplxProduct> tplxProducts;

            using (var reader = new StreamReader(@"C:\Users\jonat\Documents\ProductsForRez\RezTest1.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    tplxProducts = csv.GetRecords<TplxProduct>().ToList();
                    tplxProducts.ForEach(record => Console.WriteLine($"{record.Name} {record.Sku}"));
                }
            }
            return tplxProducts;
        }

        public static void WriteToNewCSV()
        {
            using (var writer = new StreamWriter(@"C:\Users\jonat\Documents\ProductsForRez\RezTest3.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    //csv.WriteRecords(products2);
                }
            }
        }
    }
}
