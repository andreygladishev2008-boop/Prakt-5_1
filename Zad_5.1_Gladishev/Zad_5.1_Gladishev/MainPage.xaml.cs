using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zad_5_1_Gladishev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage(string username)
        {
            InitializeComponent();
            Title = $"Добро пожаловать, {username}";
        }
    }
}
