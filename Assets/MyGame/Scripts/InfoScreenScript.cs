using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScreenScript : MonoBehaviour
{
    public Text text;
    private void Update()
    {
        if (EiManager.minigameDone)
        {
            text.text = "Gut gemacht, du hast das Ei in der richtigen Farbe gefärbt und hier her gebracht. Die Tür zum Ausgang des Labyrinths steht nun offen. Du bist wieder frei!";
        }
    }
}
