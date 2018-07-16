﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimCamController : MonoBehaviour {

    Vector2 mouseLook, smoothV;
    public float sens = 5.0f, smooth = 5.0f;

    GameObject toon;

    public Transform target;

    void Start()
    {
        toon = this.transform.parent.gameObject;
    }

    void LateUpdate()
    {
        StartCoroutine(wait());        
    }

    private void Update()
    {
        var md = GameManager.Instance.InputController.Mouseinput;
        md = Vector2.Scale(md, new Vector2(sens * smooth, sens * smooth));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smooth);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smooth);
        mouseLook += smoothV;
        toon.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, toon.transform.up);
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(0.7f);
        transform.LookAt(target.position);
    }
}
