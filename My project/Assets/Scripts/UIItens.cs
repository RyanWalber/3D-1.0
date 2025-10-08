using UnityEngine;
using UnityEngine.UI;

public class UIItens : MonoBehaviour
{
    public Text textoItens; // arraste o Text aqui pelo Inspector
    private int quantidadeItens = 0;

    // Chamado quando o jogador coleta um item
    public void AtualizarItens()
    {
        quantidadeItens++;
        textoItens.text = "Itens: " + quantidadeItens;
    }
}
