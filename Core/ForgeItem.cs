// ReSharper disable All

using System.Numerics;


namespace ForgeTools.Core;

public class Transform
{
    public Transform(Vector3 position, Vector3 rotation, Vector3 scale)
    {
        Position = position;
        Rotation = rotation;
        Scale = scale;
    }

    public Vector3 Position { get; set; }
    public Vector3 Scale { get; set; }
    public Vector3 Rotation { get; set; }
}

public class ForgeItem
{
    public ItemId ItemId { get; set; }
    public Transform Transform { get; set; }
    
    //TODO add other item properties like material ids and color
}