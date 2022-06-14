using UnityEngine;

public class TableManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Wenn der Tisch mit dem Spieler kollidiert soll der Bool true werden

        if (other.CompareTag("Player"))
        {
            SceneManager.playerHasReachedTable = true;
        }
    }
}
