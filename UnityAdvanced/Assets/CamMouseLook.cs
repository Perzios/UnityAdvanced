using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouseLook : MonoBehaviour {

    Vector2 mouseLook , smoothV;
    public float sens = 5.0f, smooth = 2.0f;

    GameObject toon;

	// Use this for initialization
	void Start () {
        toon = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md,new Vector2(sens*smooth, sens*smooth));
        smoothV.x = Mathf.Lerp(smoothV.x,md.x,1f/smooth);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smooth);
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f , 90f);
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        toon.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, toon.transform.up);
    }
}
