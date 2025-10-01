using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D ou setas
        float moveZ = Input.GetAxis("Vertical");   // W/S ou setas

        Vector3 movement = new Vector3(moveX, 0, moveZ);
        rb.AddForce(movement * speed);
    }
}
