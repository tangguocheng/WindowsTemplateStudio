using Windows.UI.Xaml.Controls;
using wts.ItemName.ViewModels;

namespace wts.ItemName.Views
{
    public sealed partial class ShellPage : Page
    {
        public ShellViewModel ViewModel { get; } = new ShellViewModel();
        
        public ShellPage()
        {
            InitializeComponent();

            ViewModel.Initialize(shellFrame, primaryListView, secondaryListView);
        }
    }
}