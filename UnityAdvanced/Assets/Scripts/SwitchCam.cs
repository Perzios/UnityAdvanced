using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour {

    public GameObject FirstCam, ThirdCam , RotCam , aimCam, target;
    public int camMode;

    private void Awake()
    {
        target.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Cam") && GameManager.Instance.InputController.isAim == false)
        {
            if (camMode == 2)
            {
                camMode = 0;
            }
            else
            {
                camMode += 1;
            }
            StartCoroutine(camChange());
        }
        else if (GameManager.Instance.InputController.isAim) {
            target.SetActive(true);
            StartCoroutine(aimChange());
        } else if (GameManager.Instance.InputController.isAim == false) {
            target.SetActive(false);
            StartCoroutine(camChange());
        }
	}

    IEnumerator camChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (camMode == 0)
        {
            FirstCam.SetActive(false);
            ThirdCam.SetActive(true);
            RotCam.SetActive(false);
            aimCam.SetActive(false);
        }
        if (camMode == 1)
        {
            FirstCam.SetActive(true);
            ThirdCam.SetActive(false);
            RotCam.SetActive(false);
            aimCam.SetActive(false);
        }
        if (camMode == 2)
        {
            FirstCam.SetActive(false);
            ThirdCam.SetActive(false);
            RotCam.SetActive(true);
            aimCam.SetActive(false);
        }
    }


        IEnumerator aimChange()
        {  
            yield return new WaitForSeconds(0.3f);
            FirstCam.SetActive(false);
            ThirdCam.SetActive(false);
            RotCam.SetActive(false);
            aimCam.SetActive(true);
        }
    }
