namespace SpeechMultiPlatform.Core.Services;

public class AuthService : IAuthService
{
    public bool IsAuthenticated()
    {
        return Preferences.Default.Get(Constants.AuthStateKey, false);
    }

    public async Task<bool> LoginAsync(AuthenticationModel authModel)
    {
        await Task.Delay(10000);

        if(string.IsNullOrEmpty(authModel.Username) || string.IsNullOrEmpty(authModel.Password))
        {
            Preferences.Default.Set(Constants.AuthStateKey, false);
            return false;
        }

        Preferences.Default.Set(Constants.AuthStateKey, true);

        return true;
    }
}