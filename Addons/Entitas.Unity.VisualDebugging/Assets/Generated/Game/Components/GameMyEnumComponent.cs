//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MyEnumComponent myEnum { get { return (MyEnumComponent)GetComponent(GameComponentsLookup.MyEnum); } }
    public bool hasMyEnum { get { return HasComponent(GameComponentsLookup.MyEnum); } }

    public void AddMyEnum(MyEnumComponent.MyEnum newMyEnum) {
        var index = GameComponentsLookup.MyEnum;
        var component = CreateComponent<MyEnumComponent>(index);
        component.myEnum = newMyEnum;
        AddComponent(index, component);
    }

    public void ReplaceMyEnum(MyEnumComponent.MyEnum newMyEnum) {
        var index = GameComponentsLookup.MyEnum;
        var component = CreateComponent<MyEnumComponent>(index);
        component.myEnum = newMyEnum;
        ReplaceComponent(index, component);
    }

    public void RemoveMyEnum() {
        RemoveComponent(GameComponentsLookup.MyEnum);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMyEnum;

    public static Entitas.IMatcher<GameEntity> MyEnum {
        get {
            if(_matcherMyEnum == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MyEnum);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMyEnum = matcher;
            }

            return _matcherMyEnum;
        }
    }
}
