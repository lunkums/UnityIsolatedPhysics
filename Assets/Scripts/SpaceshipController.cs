using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SpaceshipController : MonoBehaviour
{
    private Animator animator;
    private bool canFly;

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
