using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    public Transform jogador;
    public Vector3 deslocamento;

    void LateUpdate()
    {
        transform.position = jogador.position + deslocamento;
    }
}
