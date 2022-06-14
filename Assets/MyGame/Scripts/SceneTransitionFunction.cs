using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionFunction : MonoBehaviour
{
    public void TransitionScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
