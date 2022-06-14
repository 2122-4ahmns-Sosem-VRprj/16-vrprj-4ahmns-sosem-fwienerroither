using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("TransitionScene");
        }
    }

    public void TransitionScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}