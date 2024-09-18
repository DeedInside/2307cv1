
using _2307св1.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace _2307св1.ViewModel
{
    public class MainVM: Property
    {
        private Phone selectedPhone;
        public Phone SelectedPhone { get { return selectedPhone; } set { selectedPhone = value; OnPropertyChanged("SelectedPhone"); } }
        private string title;
        public string Title { get{ return title; } set { title = value; OnPropertyChanged("Title"); } }
        private string price;
        public string Price { get { return price; } set { price = value; OnPropertyChanged("Price"); } }
        private string company;
        public string Company { get { return company; } set { company = value; OnPropertyChanged("Company"); } }
        public ObservableCollection<Phone> Phones { get; set; } = new ObservableCollection<Phone>();
        public MainVM()
        {
            Phones = CreateDataPhone(); 
        }
        
        private RelayCommand removeElementPhone;
        public RelayCommand RemoveElementPhone
        {
            get
            {
                return removeElementPhone ??
                   (removeElementPhone = new RelayCommand(obj =>
                   {
                       if(SelectedPhone != null)
                       {
                           Phones.Remove(selectedPhone);
                       }
                   }));
            }
        }
        private RelayCommand addPhoneToList;
        public RelayCommand AddPhoneToList
        {
            get
            {
               return addPhoneToList ??
                  (addPhoneToList = new RelayCommand(obj =>
                  {
                      Phones.Add(new Phone(Title, Company, int.Parse(Price)));
                  }));
            }
        }
        private ObservableCollection<Phone> CreateDataPhone()
        {
            return new ObservableCollection<Phone>()
            {
                new Phone("Title 1","company", 111){ Id=1},
                new Phone("Title 2","company", 113){ Id=2},
                new Phone("Title 3","company", 115){ Id=3},
                new Phone("Title 4","company", 113){ Id=4},
            };
        }
    }
}
