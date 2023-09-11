using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Defines a category of resource, for example "money".
/// </summary>
public class ResourceDef
{    
    public static class For
    {
        public static IReadOnlyCollection<ResourceDef> All = new List<ResourceDef>()
        {
            Money,
            Slop
        };
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

    public static int Order(ResourceDef rd)
    {
        int result = 0;
        foreach (ResourceDef rd2 in For.All)
        {
            if (rd2 == rd)
                return result;
            result++;
        }
        return -1;
    }
}