using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Dialogs;
using AvaloniaApplication1.Interfaces;
using AvaloniaApplication1.Models;
using AvaloniaApplication1.Services;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication1.ViewModels;

public partial class MainWindowViewModel : ModelViewModelBase<Greeter>
{
#region Designer
    public MainWindowViewModel() : this(Ioc.Default.GetService<IModelService>() ?? new ModelService()) { }
#endregion

    public MainWindowViewModel(IModelService modelService) : base(modelService)
    {
        OpenFileCommand = new AsyncRelayCommand<IControl>(OnOpenFile);
    }
    
    public AsyncRelayCommand<IControl>? OpenFileCommand { get; }

    [RelayCommand]
    private void ChangeGreeting() => Model.Greeting = "ah!";

    private async Task OnOpenFile(IControl owner)
    {
        var dialog = new OpenFileDialog();
        await dialog.ShowManagedAsync(owner as Window);
    }
}