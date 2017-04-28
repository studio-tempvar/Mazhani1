using System.Collections.Generic;
using Entitas;

public class MessageLoggingSystem : ReactiveSystem<UIEntity>
{
    private readonly UIContext _uiContext;

    public MessageLoggingSystem(IContext<UIEntity> context) : base(context)
    {
    }

    public MessageLoggingSystem(ICollector<UIEntity> collector) : base(collector)
    {
    }

    public MessageLoggingSystem(Contexts con) : base(con.uI)
    {
        _uiContext = con.uI;
    }

    protected override ICollector<UIEntity> GetTrigger(IContext<UIEntity> context)
    {
        return context.CreateCollector(UIMatcher.Message);
    }

    protected override bool Filter(UIEntity entity)
    {
        return entity.hasMessage;
    }

    protected override void Execute(List<UIEntity> entities)
    {
        foreach (UIEntity e in entities)
        {
             UnityEngine.Debug.logger.Log(e.message.msg);
            e.Destroy();
        }
    }
}
