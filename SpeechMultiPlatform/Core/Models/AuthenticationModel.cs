namespace SpeechMultiPlatform.Core.Models
{
    public partial class AuthenticationModel : ViewBase
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string passwordcf;

        //public string UserName
        //{
        //    get { return _username; }
        //    set { SetProperty(ref _username, value); }
        //}

        //public string Password
        //{
        //    get { return _password; }
        //    set { SetProperty(ref _password, value); }
        //}

        //public string PasswordCf
        //{
        //    get { return _passwordcf; }
        //    set { SetProperty(ref _passwordcf, value); }
        //}
    }
}
