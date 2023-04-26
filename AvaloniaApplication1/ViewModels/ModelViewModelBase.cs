using System;
using AvaloniaApplication1.Interfaces;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.ViewModels;

public abstract partial class ModelViewModelBase<T> : ViewModelBase
    where T : ModelBase, new()
{
    public ModelViewModelBase(IModelService modelService)
    {
        ModelService = modelService ?? throw new ArgumentNullException(nameof(modelService));
        _model = modelService.Create<T>();
    }

    protected IModelService ModelService { get; }

    public T Model
    {
        get => _model;
        set => SetProperty(ref _model, value);
    }
    private T _model;
}