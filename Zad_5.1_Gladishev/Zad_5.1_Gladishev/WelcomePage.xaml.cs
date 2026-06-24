using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zad_5_1_Gladishev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameEntry.Text))
            {
                await DisplayAlert("Ошибка", "Введите имя пользователя", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordEntry.Text))
            {
                await DisplayAlert("Ошибка", "Введите пароль", "OK");
                return;
            }

            string username = UsernameEntry.Text.Trim();
            await Navigation.PushAsync(new MainPage(username));
        }

        private async void OnForgotTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Восстановление пароля", "Обратитесь к администратору", "OK");
        }
    }
}
