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
        public static List<QuickBooksProduct> GetQuickBooksRecords(string filePath)
        {
            List<QuickBooksProduct> quickbooksProducts;
            using (var reader = new StreamReader($@"{filePath}"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    quickbooksProducts = csv.GetRecords<QuickBooksProduct>().ToList();
                }
            }
            return quickbooksProducts;
        }

        public static List<TplxProduct> GetTplxRecords(string filePath)
        {
            List<TplxProduct> tplxProducts;

            using (var reader = new StreamReader($@"{filePath}"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    tplxProducts = csv.GetRecords<TplxProduct>().ToList();
                }
            }
            return tplxProducts;
        }

        public static void WriteToNewCSV(List<NewTplxProduct> newProducts, string filePath)
        {
            using (var writer = new StreamWriter($@"{filePath}"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(newProducts);
                }
            }
        }

        public static bool FilePathIsValid(string filePath)
        {
            return filePath.IndexOfAny(Path.GetInvalidPathChars()) == -1 && (filePath.EndsWith(".csv") || filePath.EndsWith(".xlsx"));
        }
    }
}
