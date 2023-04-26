using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplication1.Models;

public partial class Greeter : ModelBase
{
    public Greeter() =>
        _greeting = "Welcome to Avalonia with Community Toolkit MVVM";
    
    [ObservableProperty]
    private string _greeting;
}