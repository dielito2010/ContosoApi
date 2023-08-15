namespace Api.Domain.Product
{
    public class DimProductSubcategory
    {
        public int ProductSubcategoryKey { get; private set; }
        public string ProductSubcategoryLabel { get; private set; }
        public string ProductSubcategoryName { get; private set; }
        public string ProductSubcategoryDescription { get; private set; }
        public int ProductCategoryKey { get; private set; }
        public int ETLLoadID { get; private set; }
        public DateTime LoadDate { get; private set; }
        public DateTime UpdateDate { get; private set; }

        public DimProductSubcategory(
            int productSubcategoryKey,
            string productSubcategoryLabel,
            string productSubcategoryName,
            string productSubcategoryDescription,
            int productCategoryKey,
            int etlLoadID,
            DateTime loadDate,
            DateTime updateDate)
        {
            ProductSubcategoryKey = productSubcategoryKey;
            ProductSubcategoryLabel = productSubcategoryLabel;
            ProductSubcategoryName = productSubcategoryName;
            ProductSubcategoryDescription = productSubcategoryDescription;
            ProductCategoryKey = productCategoryKey;
            ETLLoadID = etlLoadID;
            LoadDate = loadDate;
            UpdateDate = updateDate;
        }
    }

}
