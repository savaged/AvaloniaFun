namespace AvaloniaApplication1.Interfaces;

public interface IModelService
{
    T Create<T>()
        where T : class, IModel, new();
}