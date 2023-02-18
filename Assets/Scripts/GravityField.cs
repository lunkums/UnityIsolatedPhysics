using UnityEngine;

public class GravityField : MonoBehaviour, IGravityField
{
    private Gravity gravity;

    public Gravity Gravity => gravity;
    public Transform Transform => transform.parent.parent;

    private void Awake()
    {
        gravity = new(transform);
    }
}