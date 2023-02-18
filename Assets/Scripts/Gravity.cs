using UnityEngine;

public class Gravity
{
    private Transform transform;

    public Vector3 Down => -Up;
    public Vector3 Forward => transform.forward;
    public Vector3 Up => transform.up;

    public Gravity(Transform transform)
    {
        this.transform = transform;
    }

    public void Set(Vector3 down)
    {
        // Gravity will rotate around this axis with this amount
        Vector3 axis = Vector3.Cross(Down, down);
        float angle = Vector3.Angle(Down, down);

        transform.up = -down;
        transform.forward = Quaternion.AngleAxis(angle, axis) * Forward;
    }
}
