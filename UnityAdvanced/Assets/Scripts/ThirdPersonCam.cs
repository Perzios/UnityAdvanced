using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour {

    private const float Y_ANGLE_MIN = 6.0f;
    private const float Y_ANGLE_MAX = 40.0f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    public float dist;
    private float currentX = 0.0f;
    private float currentY = 20.0f;
    private float sensitivityX = 4.0f;
    private float sensitivityY = 1.0f;

    private void Start() {
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X") * sensitivityX;
        currentY -= Input.GetAxis("Mouse Y") * sensitivityY;
        dist -= Input.GetAxis("Mouse ScrollWheel");
        currentY = Mathf.Clamp(currentY,Y_ANGLE_MIN,Y_ANGLE_MAX);
        dist = Mathf.Clamp(dist, 5.0f, 12.0f);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0 , -dist);
        Quaternion rot;
        rot = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rot * dir;        
        camTransform.LookAt(lookAt.position);        
    }
}
