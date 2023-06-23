namespace SpeechMultiPlatform.Core.Services.Interface;

public interface IAuthService
{
    Task<bool> LoginAsync(AuthenticationModel authModel);
}