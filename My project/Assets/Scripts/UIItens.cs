using UnityEngine;
using TMPro; // Biblioteca do TextMeshPro

public class UIItens : MonoBehaviour
{
    public TMP_Text textoItens; // arraste o TextMeshProUGUI aqui pelo Inspector
    private int quantidadeItens = 0;

    // Chamado quando o jogador coleta um item
    public void AtualizarItens()
    {
        quantidadeItens++;
        textoItens.text = "Itens: " + quantidadeItens;
    }
}
