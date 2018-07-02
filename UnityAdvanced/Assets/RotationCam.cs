using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCam : MonoBehaviour {

    private const float Y_ANGLE_MIN = 10.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public GameObject target;

    public float dist;

    private float currentX = 0.0f;
    private float currentY = 20.0f;
    private float sensitivityX = 4.0f;
    private float sensitivityY = 0.5f;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        currentY += Input.GetAxis("Mouse Y") * sensitivityY;
        currentX += 15.0f * sensitivityX * Time.deltaTime;
        dist -= Input.GetAxis("Mouse ScrollWheel");
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);        
        dist = Mathf.Clamp(dist, 5.0f, 12.0f);
    }


    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -dist);
        Quaternion rot;
        rot = Quaternion.Euler(currentY, currentX, 0);
        transform.position = target.transform.position + rot * dir;
        transform.LookAt(target.transform.position);
    }

}
