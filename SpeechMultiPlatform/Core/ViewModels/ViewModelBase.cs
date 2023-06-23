namespace SpeechMultiPlatform.Core.ViewModels;

public partial class ViewModelBase : ObservableObject
{
    [ObservableProperty]
    private string title;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    private bool isBusy;

    public bool IsNotBusy => !IsBusy;
}