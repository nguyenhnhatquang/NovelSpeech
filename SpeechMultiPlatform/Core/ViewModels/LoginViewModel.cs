namespace SpeechMultiPlatform.Core.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    private IAuthService _authService;

    private AuthenticationModel _authModel;

    public AuthenticationModel AuthModel
    {
        get { return _authModel; }
        set { SetProperty(ref _authModel, value); }
    }

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
        //WaitLayerControl.Open();
        if (await _authService.LoginAsync(AuthModel))
        {
            //WaitLayerControl.Close();
            //await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            await Application.Current.MainPage.DisplayAlert("Alert", "Login Success", "OK");
        }
        else
        {
            //WaitLayerControl.Close();
            await Application.Current.MainPage.DisplayAlert("Alert", "Login Failure", "OK");
        }
    }

}