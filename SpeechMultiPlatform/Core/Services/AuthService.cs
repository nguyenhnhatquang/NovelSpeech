namespace SpeechMultiPlatform.Core.Services;

public class AuthService : IAuthService
{
    public async Task<bool> LoginAsync(AuthenticationModel authModel)
    {
        await Task.Delay(3000);

        if(authModel.Username == null && authModel.Password == null)
        {
            return false;
        }

        return true;
    }
}