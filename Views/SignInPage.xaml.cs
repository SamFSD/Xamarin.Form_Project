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
            // TODO: Perform sign-in logic here

            // Navigate to the homepage
            await Navigation.PushAsync(new HomePage());
        }
    }
}
