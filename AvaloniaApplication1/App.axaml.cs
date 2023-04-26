using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaApplication1.ViewModels;
using AvaloniaApplication1.Views;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace AvaloniaApplication1;

public partial class App : Application
{
    public App() => Bootstrapper.Bootstrap();
    
    public override void Initialize() => AvaloniaXamlLoader.Load(this);

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var mvm = Ioc.Default.GetService<MainWindowViewModel>() ??
                throw new InvalidOperationException($"{nameof(MainWindowViewModel)} not set!");
            desktop.MainWindow = new MainWindow { DataContext = mvm };
        }
        base.OnFrameworkInitializationCompleted();
    }
    
}