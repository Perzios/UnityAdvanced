using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    public float Vertical, Horizontal;
    public Vector2 Mouseinput;
    public bool isJump;
    public bool isAim;

    void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        Mouseinput = new Vector2(Input.GetAxisRaw("Mouse X") , Input.GetAxisRaw("Mouse Y"));

        isJump = Input.GetButton("Jump");
        isAim = Input.GetButton("Fire2");
    }
}
