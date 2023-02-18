using UnityEngine;

public interface IGravityField
{
    Gravity Gravity { get; }
    Transform Transform { get; }
}