using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour {

    public GameObject FirstCam, ThirdCam , RotCam;
    public int camMode;

	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Cam")) {
            if (camMode == 2)
            {
                camMode = 0;
            }
            else {
                camMode += 1;
            }
            StartCoroutine(camChange());
        }
	}

    IEnumerator camChange() {
        yield return new WaitForSeconds(0.01f);
        if (camMode == 0)
        {
            FirstCam.SetActive(false);
            ThirdCam.SetActive(true);
            RotCam.SetActive(false);
        }
        if (camMode == 1)
        {
            FirstCam.SetActive(true);
            ThirdCam.SetActive(false);
            RotCam.SetActive(false);
        }
        if (camMode == 2)
        {
            FirstCam.SetActive(false);
            ThirdCam.SetActive(false);
            RotCam.SetActive(true);
        }
    }
}
