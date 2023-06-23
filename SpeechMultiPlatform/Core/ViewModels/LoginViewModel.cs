namespace SpeechMultiPlatform.Core.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    private IAuthService _authService;

    [ObservableProperty]
    private AuthenticationModel authModel;

    public ICommand LoginCommand { get; }
    public ICommand ForgotPasswordCommand { get; }

    public LoginViewModel(IAuthService authService)
    {
        _authService = authService;
        //
        AuthModel = new AuthenticationModel();
        LoginCommand = new Command(() => LoginAsync());
        ForgotPasswordCommand = new Command(() => LoginAsync());
    }

    private async void LoginAsync()
    {
        IsBusy = true;
        if (await _authService.LoginAsync(AuthModel))
        {
            IsBusy = false;
            //await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            await Application.Current.MainPage.DisplayAlert("Alert", "Login Success", "OK");
        }
        else
        {
            IsBusy = false;
            await Application.Current.MainPage.DisplayAlert("Alert", "Login Failure", "OK");
        }
    }

}