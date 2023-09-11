using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Defines a category of resource, for example "money".
/// </summary>
public class ResourceDef
{    
    public static class For
    {
        public static ResourceDef Money => new("Money", "💵");
        public static ResourceDef Slop => new("Slop", "🥘");
    }
    public string Name;
    public string TextIcon;
    public ResourceDef(string name, string textIcon)
    {
        Name = name;
        TextIcon = textIcon;
    }
    // in the future, should probably replace with a unique key for localization purposes
    public override int GetHashCode() => Name.GetHashCode();
    public override bool Equals(object obj) => obj is ResourceDef rd && rd.Name == Name;
    public static bool operator ==(ResourceDef a, ResourceDef b) => a.Equals(b);
    public static bool operator !=(ResourceDef a, ResourceDef b) => !(a == b);
}
/// <summary>
/// Represents a quantity of a given resource type, for example 5 money.
/// </summary>
public class Resource
{
    public ResourceDef Def { get; private set; }
    public string Name => Def.Name;
    public string TextIcon => Def.TextIcon;
    public float Quantity { get; set; }
    public Resource(ResourceDef def, float quantity = 0)
    {
        Def = def;
        Quantity = quantity;
    }
    public override string ToString() => $"{TextIcon} {Quantity}";
}