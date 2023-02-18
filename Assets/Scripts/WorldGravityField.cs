using UnityEngine;

public class WorldGravityField : MonoBehaviour, IGravityField
{
    private Gravity gravity;

    public static WorldGravityField Instance { get; private set; }

    public Gravity Gravity => gravity;
    public Transform Transform => transform;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        gravity = new(transform);
    }
}