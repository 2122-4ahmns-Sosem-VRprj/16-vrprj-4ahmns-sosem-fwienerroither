using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eingang : MonoBehaviour
{
    public Animator an;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("aja");
            an.SetBool("CloseEingang", true);
        }
    }
}
