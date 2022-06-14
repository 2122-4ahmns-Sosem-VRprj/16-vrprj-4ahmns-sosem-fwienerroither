using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KorbManager : MonoBehaviour
{
    public GameObject korbParent;
    public List<string> farben = new List<string>();
    public List<Color> _targetFarben = new List<Color>();
    List<string> targetFarben = new List<string>();
    public List<GameObject> eier = new List<GameObject>();

    private void Start()
    {
        // Es können keine Farben vergleichen werden, sondern lediglich der String vom Farbcode

        _targetFarben.ForEach((i)=> { targetFarben.Add(i.ToString()); });
    }

    private void Update()
    {
        // Erst wenn der Spieler den Tisch mit den Anweisungen gefunden hat, soll der Korb sichtbar werden

        if (SceneManager.playerHasReachedTable)
        {
            korbParent.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // Tag Comparison um Collision mit der Hand des Spielers auszuschließen

        if (other.CompareTag("Ei") && !eier.Contains(other.gameObject))
        {
            // Eierfarbe zur Liste hinzufügen

            farben.Add(other.GetComponent<Renderer>().material.color.ToString());

            // Ei soll nicht mehr bewegt werden können, sobald es im Korb liegt

            other.GetComponent<XRGrabInteractable>().enabled = false;

            // Ei zur Liste aller Eier im Korb hinzufügen

            eier.Add(other.gameObject);
        }

        // Sobald 3 Eier im Korb liegen, wird überprüft, ob es die richtigen sind

        if (farben.Count == 3)
        {
            // Die Listen sortieren, damit sie verglichen werden können

            farben.Sort();
            targetFarben.Sort();

            // Listen vergleichen

            if (CompareLists(farben, targetFarben))
            {
                // Wenn die Farben stimmen, soll ein entsprechender Text angezeigt werden, soll sich der Ausgang öffnen und ein Sound abgespielt werden
            }
            else
            {
               // Wenn die Farben nicht stimmen, soll ein entsprechender Text angezeigt werden, sollen die Eier despawnen und ein Sound abgespielt werden

                foreach (GameObject i in eier)
                {
                    Destroy(i);
                }

                // Listen für einen neuen Versuch leeren

                eier.Clear();
                farben.Clear();
            }
        }
    }

    bool CompareLists(List<string> l1, List<string> l2)
    {
        // Wenn die Listen nicht gleich lange sind, können sie nicht ident sein

        if (l1.Count != l2.Count)
        {
            return false;
        }

        // Alle Elemente werden überprüft, sobald eines nicht gleich ist returned die Funktion false

        for (int i = 0; i < l1.Count; i++)
        {
            if (l1[i] != l2[i])
            {
                return false;
            }
        }

        return true;
    }
}
