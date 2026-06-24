using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zad_5_1_Gladishev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            myDatePicker.Date = DateTime.Today;
            LoadRates();
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            LoadRates();
        }

        private void LoadRates()
        {
            USD.Text = "USD: 80 руб.";
            EUR.Text = "EUR: 86 руб.";
        }
    }
}
