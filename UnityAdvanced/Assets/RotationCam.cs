using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCam : MonoBehaviour {

    public GameObject target;

    public float dist, height;
    private float oldDist = 0, oldHeight = 0;
    private float sensitivityY = 0.5f;

    // Use this for initialization
    void Start () {
        height = Mathf.Clamp(height, 2.0f, 5.0f);
        dist = Mathf.Clamp(dist, 5.0f, 12.0f);
        Vector3 dir = new Vector3(0, height, -dist);
        transform.position = target.transform.position + dir;
    }
	
	// Update is called once per frame
	void Update () {

        oldHeight = height;
        height += Input.GetAxis("Mouse Y") * sensitivityY;
        oldDist = dist;
        dist -= Input.GetAxis("Mouse ScrollWheel");
        height = Mathf.Clamp(height, 2.0f, 5.0f);        
        dist = Mathf.Clamp(dist, 5.0f, 12.0f);

        Vector3 dir = new Vector3(0, height-oldHeight, dist-oldDist);
        transform.position += dir;

        transform.LookAt(target.transform.position);
        transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * 25);
    }
    
}
