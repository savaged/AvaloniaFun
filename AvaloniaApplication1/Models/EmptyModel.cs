using AvaloniaApplication1.Interfaces;

namespace AvaloniaApplication1.Models;

public class EmptyModel : ModelBase
{
    public static IModel Default => new EmptyModel { Id = 0 };
}