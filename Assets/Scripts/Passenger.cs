using UnityEngine;

namespace IsolatedPhysics
{
    /// <summary>
    /// A passenger of a <see cref="SpaceshipInterior"/>.
    /// </summary>
    public class Passenger
    {
        private IGravitator gravitator;

        private Transform originalParent;
        private IGravityField originalGravityField;

        /// <summary>
        /// Construct a passenger, overriding his parent transform and gravity.
        /// </summary>
        /// <param name="gravitator">The gravitator component of the passenger.</param>
        /// <param name="gravityField">The gravity field to override the passenger's existing gravity with.</param>
        public Passenger(IGravitator gravitator, IGravityField gravityField)
        {
            this.gravitator = gravitator;

            originalParent = gravitator.Parent;
            gravitator.Parent = gravityField.Transform;

            originalGravityField = gravitator.GravityField;
            gravitator.GravityField = gravityField;
        }

        /// <summary>
        /// The game object associated with the passenger.
        /// </summary>
        public GameObject GameObject { get; set; }

        /// <summary>
        /// Disengage from the overriding gravity field and return the passenger to his original parent and gravity.
        /// </summary>
        public void Disengage()
        {
            gravitator.Parent = originalParent;
            gravitator.GravityField = originalGravityField;
        }
    }
}
