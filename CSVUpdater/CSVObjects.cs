using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSVUpdater
{
    class QuickBooksProduct
    {
        [Index(2)]
        public string ItemName { get; set; }
        [Index(3)]
        public string ItemDescription { get; set; }
    }

    class TplxProduct
    {
        [Name("Source Item Name")]
        public string Name { get; set; }
        [Name("Teapplix SKU")]
        public string Sku { get; set; }
    }

    class NewTplxProduct
    {
        [Name("Source Item Name")]
        public string Name { get; set; }
        [Name("Teapplix SKU")]
        public string Sku { get; set; }
        [Name("Description")]
        public string Description { get; set; }
    }
}
