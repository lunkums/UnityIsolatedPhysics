using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SpaceshipInterior : MonoBehaviour
{
    private Passenger passenger;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent(out IPassenger newPassenger)) return;

        Debug.Log("Passenger entered");
        passenger = new(newPassenger.Root, transform);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Passenger exited");
        passenger.Disengage();
        passenger = null;
    }
}
