using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moverX = Input.GetAxis("Horizontal"); // A/D ou setas
        float moverZ = Input.GetAxis("Vertical");   // W/S ou setas

        Vector3 movimento = new Vector3(moverX, 0, moverZ);
        rb.AddForce(movimento * velocidade);
    }
}
