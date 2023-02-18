using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SpaceshipInterior : MonoBehaviour
{
    private Passenger passenger;

    public IGravityField GravityField { get; set; }

    private void Awake()
    {
        GravityField = GetComponentInChildren<GravityField>();
    }

    private void OnTriggerEnter(Collider other)
    {
        IGravitator gravitator = other.GetComponentInParent<IGravitator>();
        if (gravitator == null || ReferenceEquals(other.gameObject, passenger?.GameObject)) return;

        Debug.Log("New passenger entered");
        passenger = new(gravitator, GravityField)
        {
            GameObject = other.gameObject
        };
    }

    private void OnTriggerExit(Collider other)
    {
        if (passenger == null || !ReferenceEquals(other.gameObject, passenger?.GameObject)) return;

        Debug.Log("Passenger exited");
        passenger.Disengage();
        passenger = null;
    }
}
