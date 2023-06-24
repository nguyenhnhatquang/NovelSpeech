namespace SpeechMultiPlatform.Core.ViewModels;

public partial class ViewModelBase : ObservableObject
{
    private string _title;

    private bool _isBusy;

    public bool IsBusy
    {
        get { return _isBusy; }
        set { SetProperty(ref _isBusy, value); }
    }

    public bool IsNotBusy => !IsBusy;

    public string Title
    {
        get { return _title; }
        set { SetProperty(ref _title, value); }
    }
}