using AvaloniaApplication1.Interfaces;

namespace AvaloniaApplication1.Services;

public class ModelService : IModelService
{
    public T Create<T>()
        where T : class, IModel, new()
    {
        return new T();
    }
}