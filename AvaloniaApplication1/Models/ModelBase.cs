using CommunityToolkit.Mvvm.ComponentModel;
using AvaloniaApplication1.Interfaces;

namespace AvaloniaApplication1.Models;

public abstract partial class ModelBase : ObservableObject, IModel
{
    public int Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }
    private int _id;

    public virtual IModel Empty => EmptyModel.Default;
}