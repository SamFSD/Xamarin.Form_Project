using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyProject.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string username;
        private string password;
        private bool isBusy;

        public LoginPageViewModel()
        {
            Title = "Login";
            LoginCommand = new Command(async () => await ExecuteLoginCommand());
        }

        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        public Command LoginCommand { get; }

        private async Task ExecuteLoginCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var user = await UserService.AuthenticateAsync(Username, Password);

                if (user != null)
                {
                    await Shell.Current.GoToAsync("//homepage");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Invalid credentials. Please try again.", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
