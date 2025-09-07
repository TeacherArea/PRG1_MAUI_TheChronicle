using PRG1_MAUI_TheChronicle.ViewModel;

namespace PRG1_MAUI_TheChronicle.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Game();
        }
    }
}