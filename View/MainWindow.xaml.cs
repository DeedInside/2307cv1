using _2307св1.ViewModel;
using System.Windows;

namespace _2307св1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PanelPhone.DataContext = new MainVM();
            TestContext.DataContext = new TestContextVM();
        }
    }
}