using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ausgang : MonoBehaviour
{
    public Animator an;
  
    void Update()
    {
        if (EiManager.minigameDone)
        {
            an.SetBool("OpenAusgang", true);
        }
    }
}
