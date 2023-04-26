using AvaloniaApplication1.Interfaces;
using AvaloniaApplication1.Services;
using AvaloniaApplication1.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaApplication1;

internal static class Bootstrapper
{
    public static void Bootstrap()
    {
        var services = new ServiceCollection()
            .AddSingleton<IModelService, ModelService>()
            .AddTransient<MainWindowViewModel>();
        Ioc.Default.ConfigureServices(services.BuildServiceProvider());
    }
}