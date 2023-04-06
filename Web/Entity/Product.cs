using System.Collections.Generic;

namespace app.Data.Entity
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }
        public int UnitOfMeasureId { get; set; }
        public virtual Category Category { get; set; }
        public int? StatusId { get; set; }
        public virtual string Status { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        public virtual ICollection<StoreStock> StoreStock { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetail { get; set; }

    }
}
