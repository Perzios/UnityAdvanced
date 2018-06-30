using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCam : MonoBehaviour {

    public Camera cam, cam2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (cam.isActiveAndEnabled) {
            var CharacterRot = cam.transform.rotation;
            CharacterRot.x = 0;
            CharacterRot.z = 0;
            transform.rotation = CharacterRot;
        } else if (cam2.isActiveAndEnabled) {
            var CharacterRot = cam2.transform.rotation;
            CharacterRot.x = 0;
            CharacterRot.z = 0;
            transform.rotation = CharacterRot;
        }        
    }
}
