using UnityEngine;

public class Ausgang : MonoBehaviour
{
    public Animator animator;
  
    void Update()
    {
        if (EiManager.minigameDone)
        {
            animator.SetBool("OpenAusgang", true);
        }
    }
}
