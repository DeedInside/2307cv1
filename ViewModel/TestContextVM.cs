using _2307св1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _2307св1.ViewModel
{
    internal class TestContextVM
    {
        private RelayCommand stackPanel_MouseEnter;
        public RelayCommand StackPanel_MouseEnter
        {
            get
            {
                return stackPanel_MouseEnter ??
                   (stackPanel_MouseEnter = new RelayCommand(obj =>
                   {
                       MessageBox.Show("qweqweqwe");
                   }));
            }
        }
    }
}
