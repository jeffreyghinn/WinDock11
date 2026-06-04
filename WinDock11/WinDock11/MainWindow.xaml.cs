using Microsoft.UI.Xaml;
using WinDock11.ViewModels;

namespace WinDock11
{
    public sealed partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; }

        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();

            RootGrid.DataContext = ViewModel;
        }
    }
}
