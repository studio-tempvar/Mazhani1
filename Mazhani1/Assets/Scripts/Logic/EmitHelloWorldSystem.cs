using Entitas;

public class EmitHelloWorldSystem : IInitializeSystem
{
    private readonly UIContext _uiContext;

    public EmitHelloWorldSystem(Contexts contexts)
    {
        _uiContext = contexts.uI;
    }


    public void Initialize()
    {
        _uiContext.CreateEntity().AddMessage("Hello World!");
    }
}
