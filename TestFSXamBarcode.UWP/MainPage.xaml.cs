using Windows.Foundation;
using Windows.UI.ViewManagement;

namespace TestFSXamBarcode.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadApplication(new TestFSXamBarcode.App());
        }
    }
}
