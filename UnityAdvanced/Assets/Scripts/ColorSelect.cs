using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect : MonoBehaviour
{

    public Material red, blue, yellow;

    private void Awake()
    {
        int ran = Random.Range(0, 3);
        Material temp = red; // Default
        if (ran == 1)
        {
            temp = blue;
        }
        else if (ran == 2)
        {
            temp = yellow;
        }
        transform.GetComponent<Renderer>().material = temp;
    }
}
