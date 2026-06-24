using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zad_5_1_Gladishev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void OnDataChanged(object sender, EventArgs e)
        {
            CalculateLoan();
        }

        private void CalculateLoan()
        {
            if (!double.TryParse(CreditSum.Text, out double sum) ||
                !int.TryParse(TimeCredit.Text, out int months) || months <= 0) return;

            double rate = RateSlider.Value / 100;
            double overpayment = sum * rate * (months / 12.0);
            double totalPay = sum + overpayment;
            double monthlyPayment = totalPay / months;

            Payment.Text = $"{Math.Round(monthlyPayment, 2)} руб.";
            Sum.Text = $"{Math.Round(totalPay, 2)} руб.";
            Overpayment.Text = $"{Math.Round(overpayment, 2)} руб.";
        }
    }
}
