using app.Model.ViewModel.Base;
namespace app.Model.ViewModel.Product
{
    public class ListProductViewModel : BaseViewModel
    {
  
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public string ImageDisplay { get; set; }
        public string Price { get; set; }
        public string CategoryName { get; set; }
        public string UnitOfMeasureName { get; set; }
    }
}
