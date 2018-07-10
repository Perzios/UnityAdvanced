using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    Vector2 mouseLook, smoothV;
    public float sens = 5.0f, smooth = 2.0f;

    GameObject toon;
    public Camera cam;
     
    // Use this for initialization
    void Start () {
        toon = this.transform.gameObject;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        if (cam.isActiveAndEnabled) {
            var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            md = Vector2.Scale(md, new Vector2(sens * smooth, sens * smooth));
           // smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smooth);
            smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smooth);
            mouseLook += smoothV;
            mouseLook.y = Mathf.Clamp(mouseLook.y, -70f, 70f);
            transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
            //toon.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, toon.transform.up);
        }
        
    }
}
