namespace SpeechMultiPlatform.Core.Services.Interface;

public interface IAuthService
{
    bool IsAuthenticated();
    Task<bool> LoginAsync(AuthenticationModel authModel);
}