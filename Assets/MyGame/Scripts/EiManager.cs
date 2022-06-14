using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EiManager : MonoBehaviour
{
    public Material eiMaterial;
    public Color defaultColor;
    public bool isColored;
    public AudioClip correctSound;
    public AudioClip wrongSound;
    public static bool minigameDone;

    private void Start()
    {
        eiMaterial.color = defaultColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Color"))
        {
            switch (other.gameObject.GetComponent<Farbe>().farbe.ToString())
            {
                case "Rot":
                    eiMaterial.color = Color.red;
                    break;
                case "Blau":
                    eiMaterial.color = Color.blue;
                    break;
                case "Gruen":
                    eiMaterial.color = Color.green;
                    break;
            }

            isColored = true;
        }

        if (other.gameObject.CompareTag("Korb"))
        {
            if (isColored)
            {
                other.gameObject.GetComponent<AudioSource>().clip = correctSound;
                minigameDone = true;
            }
            else
            {
                other.gameObject.GetComponent<AudioSource>().clip = wrongSound;
            }

            other.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
