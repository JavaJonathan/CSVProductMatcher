using System;
using System.Collections.Generic;
using System.IO;

namespace CSVUpdater
{
    class Program
    {
        static void Main(string[] args)
        {      
            string quickbooksPath = UserInputHelper.RequestForQuickbosksPath();
            string tplxPath = UserInputHelper.RequestForTplxPath();
            string newFileCreationPath = UserInputHelper.RequestForNewFilePath();

            Console.WriteLine($@"Building new CSV... Your file will be created here: {newFileCreationPath}");

            List<QuickBooksProduct> quickbooksProducts = FileHelper.GetQuickBooksRecords(quickbooksPath);
            List<TplxProduct> tplxProducts = FileHelper.GetTplxRecords(tplxPath);
            List<NewTplxProduct> newTplxProducts = ProductMatcher.MatchProducts(quickbooksProducts, tplxProducts);

            FileHelper.WriteToNewCSV(newTplxProducts, newFileCreationPath);

            Console.WriteLine("Completed successfully.");
        }
    }
}
