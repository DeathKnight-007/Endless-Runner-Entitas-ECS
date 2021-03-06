//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity maxJumpTimeEntity { get { return GetGroup(ConfigMatcher.MaxJumpTime).GetSingleEntity(); } }
    public MaxJumpTimeComponent maxJumpTime { get { return maxJumpTimeEntity.maxJumpTime; } }
    public bool hasMaxJumpTime { get { return maxJumpTimeEntity != null; } }

    public ConfigEntity SetMaxJumpTime(float newValue) {
        if (hasMaxJumpTime) {
            throw new Entitas.EntitasException("Could not set MaxJumpTime!\n" + this + " already has an entity with MaxJumpTimeComponent!",
                "You should check if the context already has a maxJumpTimeEntity before setting it or use context.ReplaceMaxJumpTime().");
        }
        var entity = CreateEntity();
        entity.AddMaxJumpTime(newValue);
        return entity;
    }

    public void ReplaceMaxJumpTime(float newValue) {
        var entity = maxJumpTimeEntity;
        if (entity == null) {
            entity = SetMaxJumpTime(newValue);
        } else {
            entity.ReplaceMaxJumpTime(newValue);
        }
    }

    public void RemoveMaxJumpTime() {
        maxJumpTimeEntity.Destroy();
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
public partial class ConfigEntity {

    public MaxJumpTimeComponent maxJumpTime { get { return (MaxJumpTimeComponent)GetComponent(ConfigComponentsLookup.MaxJumpTime); } }
    public bool hasMaxJumpTime { get { return HasComponent(ConfigComponentsLookup.MaxJumpTime); } }

    public void AddMaxJumpTime(float newValue) {
        var index = ConfigComponentsLookup.MaxJumpTime;
        var component = CreateComponent<MaxJumpTimeComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMaxJumpTime(float newValue) {
        var index = ConfigComponentsLookup.MaxJumpTime;
        var component = CreateComponent<MaxJumpTimeComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMaxJumpTime() {
        RemoveComponent(ConfigComponentsLookup.MaxJumpTime);
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
public sealed partial class ConfigMatcher {

    static Entitas.IMatcher<ConfigEntity> _matcherMaxJumpTime;

    public static Entitas.IMatcher<ConfigEntity> MaxJumpTime {
        get {
            if (_matcherMaxJumpTime == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.MaxJumpTime);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherMaxJumpTime = matcher;
            }

            return _matcherMaxJumpTime;
        }
    }
}
