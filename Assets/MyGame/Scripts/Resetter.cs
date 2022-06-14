using UnityEngine;
using UnityEngine.UI;

public class Resetter : MonoBehaviour
{
    public Text infotext;

    // Wenn der Spieler zurück zu den Eiern geht, um einen neuen Versuch zu starten, soll der Infotext zurückgesetzt werden

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infotext.text = "Lege die Eier jeweils hier in den Korb.";
        }

        gameObject.SetActive(false);
    }
}
