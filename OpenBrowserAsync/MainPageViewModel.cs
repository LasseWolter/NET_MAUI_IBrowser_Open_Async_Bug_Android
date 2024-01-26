using System.Diagnostics;
using System.Windows.Input;

namespace OpenBrowserAsync;

public class MainPageViewModel
{
    public ICommand OpenBrowserCommand { get; }

    public MainPageViewModel()
    {
        OpenBrowserCommand = new Command(async () => await OpenBrowserAsync());
    }
    
    private async Task OpenBrowserAsync()
    {
        try
        {
            await Browser.OpenAsync("https://google.com", BrowserLaunchMode.External);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
        }
    }
}