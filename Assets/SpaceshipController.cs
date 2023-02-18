using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SpaceshipController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity += Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity += Vector3.right;
        }

        rb.velocity = velocity.normalized * speed;
    }
}
