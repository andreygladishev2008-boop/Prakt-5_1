using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zad_5_2_Gladishev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElementsPage : ContentPage
    {
        private string _username;

        public ElementsPage(string username)
        {
            InitializeComponent();
            _username = username;
            Title = $"Элементы — {username}";
        }

        private void OnDropdownChanged(object sender, EventArgs e)
        {
            // Обновление при изменении выпадающего списка
        }

        private void OnSliderChanged(object sender, ValueChangedEventArgs e)
        {
            Slider1Value.Text = $"{Math.Round(Slider1.Value, 1)}";
            Slider2Value.Text = $"{Math.Round(Slider2.Value, 1)}";
            Slider3Value.Text = $"{Math.Round(Slider3.Value, 1)}";
        }

        private void OnToggleToggled(object sender, ToggledEventArgs e)
        {
            // Обновление при переключении
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            string selectedItem = "Не выбрано";
            if (DropdownPicker.SelectedIndex >= 0)
            {
                selectedItem = DropdownPicker.Items[DropdownPicker.SelectedIndex];
            }

            double maxValue = Math.Max(Slider1.Value, Math.Max(Slider2.Value, Slider3.Value));

            string description = GetDescription(selectedItem);

            await Navigation.PushAsync(new ResultPage(selectedItem, description, maxValue));
        }

        private async void OnStaticClicked(object sender, EventArgs e)
        {
            double currentMax = Math.Max(Slider1.Value, Math.Max(Slider2.Value, Slider3.Value));

            await Navigation.PushAsync(new ResultPage(
                "Static (Вариант 2)",
                $"Максимальное текущее значение среди слайдеров: {Math.Round(currentMax, 1)}",
                currentMax));
        }

        private string GetDescription(string item)
        {
            switch (item)
            {
                case "Select One": return "Выбран первый элемент списка";
                case "Select Two": return "Выбран второй элемент списка";
                case "Select Three": return "Выбран третий элемент списка";
                case "Select Four": return "Выбран четвёртый элемент списка";
                default: return "Элемент не выбран";
            }
        }
    }
}
