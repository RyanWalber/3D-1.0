using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    public UIItens uiItens; // arraste o Canvas com UIItens aqui

    private void OnTriggerEnter(Collider outro)
    {
        // Verifica se quem colidiu é o Player
        if (outro.CompareTag("Player"))
        {
            // Atualiza a contagem de itens na UI
            if (uiItens != null)
            {
                uiItens.AtualizarItens();
            }

            // Remove o item da cena
            Destroy(gameObject);
        }
    }
}
