namespace Api.Domain.Product
{
    public class DimProductCategory
    {
        public int ProductCategoryKey { get; private set; }
        public string ProductCategoryLabel { get; private set; }
        public string ProductCategoryName { get; private set; }
        public string ProductCategoryDescription { get; private set; }
        public int ETLLoadID { get; private set; }
        public DateTime LoadDate { get; private set; }
        public DateTime UpdateDate { get; private set; }

        private DimProductCategory() { }

        public DimProductCategory(int productCategoryKey, string productCategoryLabel,
                                  string productCategoryName, string productCategoryDescription,
                                  int eTLLoadID, DateTime loadDate, DateTime updateDate)
        {
            ProductCategoryKey = productCategoryKey;
            ProductCategoryLabel = productCategoryLabel;
            ProductCategoryName = productCategoryName;
            ProductCategoryDescription = productCategoryDescription;
            ETLLoadID = eTLLoadID;
            LoadDate = loadDate;
            UpdateDate = updateDate;
        }
    }

}
