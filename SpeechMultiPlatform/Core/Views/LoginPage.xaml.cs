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

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        //var loggedin = true;
        //if(loggedin)
        //await Shell.Current.GoToAsync($"//{nameof(CoffeeEquipmentPage)}");
    }
    
    private void Button_Clicked(object sender, EventArgs e)
    {
        
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        
    }
}