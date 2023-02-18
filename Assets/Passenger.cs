using UnityEngine;

public class Passenger
{
    private Transform transform;
    private Transform originalParent;

    public Passenger(Transform transform, Transform newParent)
    {
        this.transform = transform;
        originalParent = transform.parent;
        transform.parent = newParent;
    }

    public void Disengage()
    {
        transform.parent = originalParent;
    }
}