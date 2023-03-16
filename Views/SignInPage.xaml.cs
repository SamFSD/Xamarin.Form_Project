using Xamarin.Forms;

namespace MyApp.Views
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private async void SignInButton_Clicked(object sender, EventArgs e)
        {
            var username = UsernameEntry.Text;
            var password = PasswordEntry.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Username and password are required.", "OK");
                return;
            }

            var isAuthenticated = await _userService.AuthenticateUser(username, password);

            if (isAuthenticated)
            {

            // Navigate to the homepage
            await Navigation.PushAsync(new HomePage());
        }
    }
}
