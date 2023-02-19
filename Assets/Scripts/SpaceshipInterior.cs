using UnityEngine;

namespace IsolatedPhysics
{
    /// <summary>
    /// The interior of a spaceship, including its passengers.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public class SpaceshipInterior : MonoBehaviour
    {
        private Passenger passenger;

        /// <summary>
        /// The field of gravity to which the passengers are attracted.
        /// </summary>
        public IGravityField GravityField { get; set; }

        private void Awake()
        {
            GravityField = GetComponentInChildren<GravityField>();
        }

        /**
         * If there is a new passenger, add him and override his gravity.
         */
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

        /**
         * If an existing passenger is leaving, disengage him from the gravity field.
         */
        private void OnTriggerExit(Collider other)
        {
            if (passenger == null || !ReferenceEquals(other.gameObject, passenger?.GameObject)) return;

            Debug.Log("Passenger exited");
            passenger.Disengage();
            passenger = null;
        }
    }
}
