using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.User
{
    public class ListUserViewModel : BaseViewModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageDisplay { get; set; }
        public string EmployeeType { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
    }
}
