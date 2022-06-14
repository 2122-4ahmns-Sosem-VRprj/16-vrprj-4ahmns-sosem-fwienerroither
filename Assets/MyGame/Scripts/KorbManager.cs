using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorbManager : MonoBehaviour
{
    public GameObject korbParent;

    private void Update()
    {
        if (EiManager.reachedMinigame)
        {
            korbParent.SetActive(true);
        }
    }
}
