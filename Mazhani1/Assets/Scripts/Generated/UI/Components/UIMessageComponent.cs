//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UIEntity {

    public MessageComponent message { get { return (MessageComponent)GetComponent(UIComponentsLookup.Message); } }
    public bool hasMessage { get { return HasComponent(UIComponentsLookup.Message); } }

    public void AddMessage(string newMsg) {
        var index = UIComponentsLookup.Message;
        var component = CreateComponent<MessageComponent>(index);
        component.msg = newMsg;
        AddComponent(index, component);
    }

    public void ReplaceMessage(string newMsg) {
        var index = UIComponentsLookup.Message;
        var component = CreateComponent<MessageComponent>(index);
        component.msg = newMsg;
        ReplaceComponent(index, component);
    }

    public void RemoveMessage() {
        RemoveComponent(UIComponentsLookup.Message);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UIMatcher {

    static Entitas.IMatcher<UIEntity> _matcherMessage;

    public static Entitas.IMatcher<UIEntity> Message {
        get {
            if (_matcherMessage == null) {
                var matcher = (Entitas.Matcher<UIEntity>)Entitas.Matcher<UIEntity>.AllOf(UIComponentsLookup.Message);
                matcher.componentNames = UIComponentsLookup.componentNames;
                _matcherMessage = matcher;
            }

            return _matcherMessage;
        }
    }
}
