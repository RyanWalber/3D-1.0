using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");

        // Aqui trocamos os eixos X e Z
        Vector3 movimento = new Vector3(movimentoVertical, 0f, -movimentoHorizontal);

        rb.AddForce(movimento * velocidade);
    }
}
