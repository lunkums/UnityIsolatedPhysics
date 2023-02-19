using UnityEngine;

namespace IsolatedPhysics
{
    /// <summary>
    /// A component to control the animation of the spaceship.
    /// </summary>
    [RequireComponent(typeof(Animator))]
    public class SpaceshipController : MonoBehaviour
    {
        private Animator animator;
        private bool canFly;

        /// <summary>
        /// Reset the animation and allow it to play again.
        /// </summary>
        public void ResetAnimation()
        {
            animator.ResetTrigger("Fly");
            canFly = true;
        }

        private void Awake()
        {
            animator = GetComponent<Animator>();
            canFly = true;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R) && canFly)
            {
                animator.SetTrigger("Fly");
                canFly = false;
            }
        }
    }
}
