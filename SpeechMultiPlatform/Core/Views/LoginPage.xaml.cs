namespace SpeechMultiPlatform.Core.Views;

public partial class LoginPage : ContentPage
{
    private LoginViewModel _viewModel;
    private IAuthService _authService;

    public LoginPage()
    {
        InitializeComponent();
        _authService = new AuthService();
        _viewModel = new LoginViewModel(_authService);
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (_authService.IsAuthenticated())
        {
            // Set Nav 
        }
    }
}