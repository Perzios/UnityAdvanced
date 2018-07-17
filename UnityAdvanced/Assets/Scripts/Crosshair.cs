using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{

    [SerializeField]
    Texture2D image;

    [SerializeField]
    float crosshairSize;

    float lookHeight, maxAngle = 60f, minAngle = -60f;

    public void LookHeight(float val)
    {
        lookHeight += val;

        if (lookHeight > maxAngle || lookHeight < minAngle)
        {
            lookHeight -= val;
        }
    }

    private void OnGUI()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        GUI.DrawTexture(new Rect((Screen.width / 2) - (crosshairSize / 2), (Screen.height / 2) - (crosshairSize / 2) + 50f, crosshairSize, crosshairSize), image);
    }
}
