using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ausgang : MonoBehaviour
{
    public Animator an;
  
    void Update()
    {
        if (KorbManager.minigameDone)
        {
            an.SetBool("OpenAusgang", true);
        }
    }
}
