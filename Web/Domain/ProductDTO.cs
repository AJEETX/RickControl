﻿namespace app.Model.Domain
{
    public class ProductDTO : BaseDTO
    {
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? StatusId  { get; set; }
        public string Status  { get; set; }
        public int? UnitOfMeasureId { get; set; }
        public string UnitOfMeasureName { get; set; }

    }
}
