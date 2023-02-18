using UnityEngine;

public interface IGravitator
{
    IGravityField GravityField { get; set; }
    Transform Transform { get; }
    Transform Parent
    {
        get => Transform.parent;
        set
        {
            Transform.parent = value;
            OnParentChanged();
        }
    }

    void OnParentChanged();
}