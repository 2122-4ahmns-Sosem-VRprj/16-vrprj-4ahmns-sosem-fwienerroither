using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource ambience;
    public AudioSource kuekenIdle; 
    public AudioSource correctSound;
    public AudioSource wrongSound;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ambience.Play();
        kuekenIdle.Play();
    }

    public void PlaySound(AudioSource audioSource)
    {
        audioSource.Play();
    }
}
