namespace Api.Domain.Product
{
    public class DimProduct
    {
        public int ProductKey { get; private set; }
        public string ProductLabel { get; private set; }
        public string ProductName { get; private set; }
        public string ProductDescription { get; private set; }
        public int ProductSubcategoryKey { get; private set; }
        public string Manufacturer { get; private set; }
        public string BrandName { get; private set; }
        public int ClassID { get; private set; }
        public string ClassName { get; private set; }
        public string StyleID { get; private set; }
        public string StyleName { get; private set; }
        public string ColorID { get; private set; }
        public string ColorName { get; private set; }
        public string Size { get; private set; }
        public string SizeRange { get; private set; }
        public string SizeUnitMeasureID { get; private set; }
        public decimal Weight { get; private set; }
        public string WeightUnitMeasureID { get; private set; }
        public string UnitOfMeasureID { get; private set; }
        public string UnitOfMeasureName { get; private set; }
        public string StockTypeID { get; private set; }
        public string StockTypeName { get; private set; }
        public decimal UnitCost { get; private set; }
        public decimal UnitPrice { get; private set; }
        public DateTime AvailableForSaleDate { get; private set; }
        public DateTime? StopSaleDate { get; private set; }
        public string Status { get; private set; }
        public string ImageURL { get; private set; }
        public string ProductURL { get; private set; }
        public int ETLLoadID { get; private set; }
        public DateTime LoadDate { get; private set; }
        public DateTime UpdateDate { get; private set; }

        private DimProduct() { }

        public DimProduct(int productKey, string productLabel, string productName, string productDescription,
                          int productSubcategoryKey, string manufacturer, string brandName, int classID,
                          string className, string styleID, string styleName, string colorID, string colorName,
                          string size, string sizeRange, string sizeUnitMeasureID, decimal weight,
                          string weightUnitMeasureID, string unitOfMeasureID, string unitOfMeasureName,
                          string stockTypeID, string stockTypeName, decimal unitCost, decimal unitPrice,
                          DateTime availableForSaleDate, DateTime? stopSaleDate, string status, string imageURL,
                          string productURL, int eTLLoadID, DateTime loadDate, DateTime updateDate)
        {
            ProductKey = productKey;
            ProductLabel = productLabel;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductSubcategoryKey = productSubcategoryKey;
            Manufacturer = manufacturer;
            BrandName = brandName;
            ClassID = classID;
            ClassName = className;
            StyleID = styleID;
            StyleName = styleName;
            ColorID = colorID;
            ColorName = colorName;
            Size = size;
            SizeRange = sizeRange;
            SizeUnitMeasureID = sizeUnitMeasureID;
            Weight = weight;
            WeightUnitMeasureID = weightUnitMeasureID;
            UnitOfMeasureID = unitOfMeasureID;
            UnitOfMeasureName = unitOfMeasureName;
            StockTypeID = stockTypeID;
            StockTypeName = stockTypeName;
            UnitCost = unitCost;
            UnitPrice = unitPrice;
            AvailableForSaleDate = availableForSaleDate;
            StopSaleDate = stopSaleDate;
            Status = status;
            ImageURL = imageURL;
            ProductURL = productURL;
            ETLLoadID = eTLLoadID;
            LoadDate = loadDate;
            UpdateDate = updateDate;

            //Validate();
        }

        /*private void Validate()
        {
            //var contract = new Contract<DimProduct>()
                .IsNotNullOrEmpty(ProductKey, "ProductKey is required")
                .IsNotNullOrEmpty(ColorName, "ColorName is required")
                .IsMaxLength(ProductLabel, 255, "ProductName", "ProductLabel must have a maximum of 255 characters")
                .IsMaxLength(ProductName, 500, "ProductName", "ProductName must have a maximum of 500 characters")
                .IsMaxLength(ProductDescription, 400, "ProductName", "ProductDescription must have a maximum of 500 characters")
                .IsMaxLength(ProductName, 500, "ProductName", "ProductName must have a maximum of 500 characters")
        }*/
    }

}
