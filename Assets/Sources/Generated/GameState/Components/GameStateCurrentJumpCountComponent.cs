//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity currentJumpCountEntity { get { return GetGroup(GameStateMatcher.CurrentJumpCount).GetSingleEntity(); } }
    public CurrentJumpCountComponent currentJumpCount { get { return currentJumpCountEntity.currentJumpCount; } }
    public bool hasCurrentJumpCount { get { return currentJumpCountEntity != null; } }

    public GameStateEntity SetCurrentJumpCount(int newValue) {
        if (hasCurrentJumpCount) {
            throw new Entitas.EntitasException("Could not set CurrentJumpCount!\n" + this + " already has an entity with CurrentJumpCountComponent!",
                "You should check if the context already has a currentJumpCountEntity before setting it or use context.ReplaceCurrentJumpCount().");
        }
        var entity = CreateEntity();
        entity.AddCurrentJumpCount(newValue);
        return entity;
    }

    public void ReplaceCurrentJumpCount(int newValue) {
        var entity = currentJumpCountEntity;
        if (entity == null) {
            entity = SetCurrentJumpCount(newValue);
        } else {
            entity.ReplaceCurrentJumpCount(newValue);
        }
    }

    public void RemoveCurrentJumpCount() {
        currentJumpCountEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public CurrentJumpCountComponent currentJumpCount { get { return (CurrentJumpCountComponent)GetComponent(GameStateComponentsLookup.CurrentJumpCount); } }
    public bool hasCurrentJumpCount { get { return HasComponent(GameStateComponentsLookup.CurrentJumpCount); } }

    public void AddCurrentJumpCount(int newValue) {
        var index = GameStateComponentsLookup.CurrentJumpCount;
        var component = CreateComponent<CurrentJumpCountComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCurrentJumpCount(int newValue) {
        var index = GameStateComponentsLookup.CurrentJumpCount;
        var component = CreateComponent<CurrentJumpCountComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCurrentJumpCount() {
        RemoveComponent(GameStateComponentsLookup.CurrentJumpCount);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherCurrentJumpCount;

    public static Entitas.IMatcher<GameStateEntity> CurrentJumpCount {
        get {
            if (_matcherCurrentJumpCount == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.CurrentJumpCount);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherCurrentJumpCount = matcher;
            }

            return _matcherCurrentJumpCount;
        }
    }
}