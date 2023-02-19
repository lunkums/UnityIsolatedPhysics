using UnityEngine;

namespace IsolatedPhysics
{
    /// <summary>
    /// A physical area with a distinct <see cref="IsolatedPhysics.Gravity"/>.
    /// </summary>
    public interface IGravityField
    {
        /// <summary>
        /// The <see cref="IsolatedPhysics.Gravity"/> of the field.
        /// </summary>
        Gravity Gravity { get; }

        /// <summary>
        /// The transform associated with the field's <see cref="IsolatedPhysics.Gravity"/>.
        /// </summary>
        Transform Transform { get; }
    }
}