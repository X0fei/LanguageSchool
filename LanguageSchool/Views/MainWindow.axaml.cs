using Avalonia.Controls;
using LanguageSchool.Services;

namespace LanguageSchool.Views
{
    /// <summary>
    /// Класс окна входа.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Конструктор окна входа.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void LogInButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var user = UserService.GetUser(LoginTextBox.Text);

            if (user is { Password: var password} && password == PasswordTextBox.Text)
            {
                ServicesWindow servicesWindow = new();
                servicesWindow.Show();
                Close();
            }
        }

        private void TextBox_TextChanged(object? sender, Avalonia.Controls.TextChangedEventArgs e)
        {
            LogInButton.IsEnabled = 
                !string.IsNullOrWhiteSpace(LoginTextBox.Text) &&
                !string.IsNullOrWhiteSpace(PasswordTextBox.Text);
        }
    }
}