using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{

    [SerializeField]
    Texture2D image;

    [SerializeField]
    float crosshairSize;



    private void OnGUI()
    {
        GUI.DrawTexture(new Rect((Screen.width / 2) - (crosshairSize / 2), (Screen.height / 2) - (crosshairSize / 2) + (Screen.height / 8), crosshairSize, crosshairSize), image);
    }
}
