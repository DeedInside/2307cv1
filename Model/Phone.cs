using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2307св1
{
    public class Phone : Property
    {
        public int Id { get; set; }

        private string title;
        public string Title 
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        private string company;
        public string Company 
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
                OnPropertyChanged("Company");
            }
        }
        private int price;
        public int Price 
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public override string ToString()
        {
            return $"{Id} - {Title} - {Company} - {Price}";
        }

        public Phone(string title, string company, int price)
        {
            Title = title;
            Company = company;
            Price = price;
        }
    }
}
