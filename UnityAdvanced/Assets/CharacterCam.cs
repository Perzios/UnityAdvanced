using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCam : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var CharacterRot = cam.transform.rotation;
        CharacterRot.x = 0;
        CharacterRot.z = 0;
        transform.rotation = CharacterRot;
    }
}
