﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCam : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform);
        transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime*25);
	}
}
