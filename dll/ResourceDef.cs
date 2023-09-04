using System.Text.Json;
using System.Text.Json.Serialization;

namespace com.libcraft.unusualkitchen;
/// <summary>
/// Represents a category of resource, such as money or steel.
/// </summary>
public class ResourceDef
{
    /// <summary>
    /// The path to a texture which will be loaded to represent this resource in-game.
    /// </summary>
    [JsonInclude]
    public string IconPath { get; private set; }
    /// <summary>
    /// The name which will be displayed for this resource.
    /// </summary>
    /// <remarks>Todo: internationalization support?</remarks>
    [JsonInclude]
    public string Name { get; private set; }
    /// <summary>
    /// If this value is not <see langword="null"/>, a <see cref="Resource"/> with this as its <c>Def</c> cannot have a
    /// <see cref="Resource.Quantity">Quantity</see> lower than this.
    /// </summary>
    public float? MinQuantity { get; private set; } = 0f;
    /// <summary>
    /// If this value is not <see langword="null"/>, a <see cref="Resource"/> with this as its <c>Def</c> cannot have a
    /// <see cref="Resource.Quantity">Quantity</see> higher than this.
    /// </summary>
    public float? MaxQuantity { get; private set; } = null;
    [JsonConstructor]
    public ResourceDef(string name, string iconPath)
    {
        Name = name;
        IconPath = iconPath;
    }
}
