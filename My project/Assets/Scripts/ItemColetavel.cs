using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    public UIItens uiItens; // arraste o Canvas com script UIItens aqui no Inspector

    private void OnTriggerEnter(Collider outro)
    {
        // Verifica se o que tocou é o Player
        if (outro.CompareTag("Player"))
        {
            uiItens.AtualizarItens(); // aumenta a contagem na UI
            Destroy(gameObject); // destrói o item da cena
        }
    }
}
