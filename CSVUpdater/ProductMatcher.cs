using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSVUpdater
{
    class ProductMatcher
    {
        public static List<NewTplxProduct> MatchProducts(List<QuickBooksProduct> quickBooksProducts, List<TplxProduct> tplxProducts)
        {
            List<NewTplxProduct> newTplxProducts = new List<NewTplxProduct>();

            tplxProducts.ForEach(tplxProduct =>
            {
                var newDescription = quickBooksProducts.Where(quickbooksProduct => quickbooksProduct.ItemName.Equals(tplxProduct.Sku)).SingleOrDefault()?.ItemDescription;

                newTplxProducts.Add(new NewTplxProduct
                {
                    Name = tplxProduct.Name,
                    Sku = tplxProduct.Sku,
                    Description = newDescription
                });
            });
            return newTplxProducts;
        }
    }
}
