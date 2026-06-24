using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zad_5_2_Gladishev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage(string selectedItem, string description, double maxValue)
        {
            InitializeComponent();

            SelectedItemLabel.Text = selectedItem;
            DescriptionLabel.Text = description;
            MaxSliderLabel.Text = maxValue.ToString();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
