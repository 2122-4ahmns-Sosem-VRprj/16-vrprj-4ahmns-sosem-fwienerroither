using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farbe : MonoBehaviour
{
    public Material material;

    public enum MyEnum
    {
        Rot,
        Blau,
        Gruen
    };

    public MyEnum farbe;

    void Update()
    {
        switch (farbe.ToString())
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
    }
}
