using Microsoft.Extensions.Logging;

namespace Sentry.Samples.Maui;

public partial class MainPage
{
    private readonly ILogger<MainPage> _logger;

    // NOTE: You can only inject an ILogger<T>, not a plain ILogger
    public MainPage(ILogger<MainPage> logger)
    {
        _logger = logger;
        InitializeComponent();
    }
}
