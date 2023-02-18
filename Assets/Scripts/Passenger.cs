using UnityEngine;

public class Passenger
{
    private IGravitator gravitator;

    private Transform originalParent;
    private IGravityField originalGravityField;

    public Passenger(IGravitator gravitator, IGravityField gravityField)
    {
        this.gravitator = gravitator;

        originalParent = gravitator.Parent;
        gravitator.Parent = gravityField.Transform;

        originalGravityField = gravitator.GravityField;
        gravitator.GravityField = gravityField;
    }

    public GameObject GameObject { get; set; }

    public void Disengage()
    {
        gravitator.Parent = originalParent;
        gravitator.GravityField = originalGravityField;
    }
}