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
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D ou setas
        float moveVertical = Input.GetAxis("Vertical");     // W/S ou setas
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 newVelocity = movement * speed;
        newVelocity.y = rb.velocity.y; // mantém a gravidade
        rb.velocity = newVelocity;
    }
}
