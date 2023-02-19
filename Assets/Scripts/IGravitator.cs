using UnityEngine;

namespace IsolatedPhysics
{
    /// <summary>
    /// An object which gravitates towards a <see cref="IsolatedPhysics.GravityField"/>.
    /// </summary>
    public interface IGravitator
    {
        /// <summary>
        /// The <see cref="IsolatedPhysics.GravityField"/> to which the gravitator is attracted.
        /// </summary>
        IGravityField GravityField { get; set; }

        /// <summary>
        /// The transform corresponding to the gravitator.
        /// </summary>
        Transform Transform { get; }

        /// <summary>
        /// The parent of the gravitator's <see cref="Transform"/>.
        /// </summary>
        Transform Parent
        {
            get => Transform.parent;
            set
            {
                Transform.parent = value;
                OnParentChanged();
            }
        }

        /// <summary>
        /// The action performed when the <see cref="Parent"> transform changes.
        /// </summary>
        void OnParentChanged();
    }
}
