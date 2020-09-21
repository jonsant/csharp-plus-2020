using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Session07FilesExample
{
    class ProductNameComparer : IComparer<Product>
    {
        public int Compare([NotNull] Product x, [AllowNull] Product y)
        {
            //Enkelt sätt att använda underliggande egenskaper
            return x.ProductName.CompareTo(y.ProductName);
        }
    }
}
