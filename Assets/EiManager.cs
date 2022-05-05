using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EiManager : MonoBehaviour
{
    public Material material;
    public bool isColored;
    public AudioClip correctSound;
    public AudioClip wrongSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Color"))
        {
            switch (other.gameObject.GetComponent<Farbe>().farbe.ToString())
            {
                case "Rot":
                    material.color = Color.red;
                    break;
                case "Blau":
                    material.color = Color.blue;
                    break;
                case "Gruen":
                    material.color = Color.green;
                    break;
            }

            isColored = true;
        }

        if (other.gameObject.CompareTag("Korb"))
        {
            if (isColored)
            {
            other.gameObject.GetComponent<AudioSource>().clip = correctSound;
            }
            else
            {
                other.gameObject.GetComponent<AudioSource>().clip = wrongSound;
            }

            other.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
