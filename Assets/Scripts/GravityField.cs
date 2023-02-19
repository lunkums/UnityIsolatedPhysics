using UnityEngine;

namespace IsolatedPhysics
{
    /// <summary>
    /// A MonoBehaviour implementation of a <see cref="IGravityField">IGravityField</see>.
    /// </summary>
    public class GravityField : MonoBehaviour, IGravityField
    {
        [SerializeField] private Transform root;

        private Gravity gravity;

        public Gravity Gravity => gravity;

        public Transform Transform => root;

        private void Awake()
        {
            gravity = new(transform);
        }
    }
}
