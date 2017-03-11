//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Vector2Component vector2 { get { return (Vector2Component)GetComponent(GameComponentsLookup.Vector2); } }
    public bool hasVector2 { get { return HasComponent(GameComponentsLookup.Vector2); } }

    public void AddVector2(UnityEngine.Vector2 newVector2) {
        var index = GameComponentsLookup.Vector2;
        var component = CreateComponent<Vector2Component>(index);
        component.vector2 = newVector2;
        AddComponent(index, component);
    }

    public void ReplaceVector2(UnityEngine.Vector2 newVector2) {
        var index = GameComponentsLookup.Vector2;
        var component = CreateComponent<Vector2Component>(index);
        component.vector2 = newVector2;
        ReplaceComponent(index, component);
    }

    public void RemoveVector2() {
        RemoveComponent(GameComponentsLookup.Vector2);
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

    static Entitas.IMatcher<GameEntity> _matcherVector2;

    public static Entitas.IMatcher<GameEntity> Vector2 {
        get {
            if(_matcherVector2 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Vector2);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherVector2 = matcher;
            }

            return _matcherVector2;
        }
    }
}
