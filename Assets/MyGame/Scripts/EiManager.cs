using UnityEngine;

public class EiManager : MonoBehaviour
{
    public Material eiMaterial;
    public Color defaultColor;
    public AudioClip correctSound;
    public AudioClip wrongSound;
     
    private void Start()
    {
        GetComponent<Renderer>().material.color = defaultColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Color"))
        {
            switch (other.gameObject.GetComponent<Renderer>().material.color)
            {
                case var value when value == Color.red:
                    GetComponent<Renderer>().material.color = Color.red;
                    break;
                case var value when value == Color.blue:
                    GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case var value when value == Color.green:
                    GetComponent<Renderer>().material.color = Color.green;
                    break;

            }
        }
    }
}
