using UnityEngine;

namespace IsolatedPhysics
{
    /// <summary>
    /// The orientation of gravity relative to a parent transform.
    /// </summary>
    public class Gravity
    {
        private Transform transform;

        /// <summary>
        /// Construct the gravity in terms of a transform's orientation.
        /// </summary>
        /// <param name="transform">The transform on which to base the gravity.</param>
        public Gravity(Transform transform)
        {
            this.transform = transform;
        }

        /// <summary>
        /// The 'down' direction of gravity.
        /// </summary>
        public Vector3 Down => -Up;

        /// <summary>
        /// The 'forward' direction of gravity.
        /// </summary>
        public Vector3 Forward => transform.forward;

        /// <summary>
        /// The 'up' direction of gravity.
        /// </summary>
        public Vector3 Up => transform.up;

        /// <summary>
        /// Set the orientation of gravity by defining the new <see cref="Down"/> vector.
        /// </summary>
        /// <param name="down"></param>
        public void Set(Vector3 down)
        {
            // Gravity will rotate around this axis with this amount
            Vector3 axis = Vector3.Cross(Down, down);
            float angle = Vector3.Angle(Down, down);

            transform.up = -down;
            transform.forward = Quaternion.AngleAxis(angle, axis) * Forward;
        }
    }
}
