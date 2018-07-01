using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherControls : MonoBehaviour {

    static Animator anim;
    public float speed = 10.0f;
    public float rotSpeed = 150.0f;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {

        float translation = Input.GetAxis("Vertical") * speed;
        float rot = Input.GetAxis("Horizontal") * rotSpeed;
        translation *= Time.deltaTime;
        rot *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0,rot,0);

        if (Input.GetButtonDown("Jump") && translation == 0)
        {
            anim.SetTrigger("isJump");
        }
        else if (Input.GetButtonDown("Jump") && translation > 0)
        {
            anim.SetTrigger("isJump");
        }
        else if(Input.GetButtonDown("Jump") && translation < 0){
            anim.SetTrigger("isJumpBack");
        }

        if (Input.GetButtonDown("Fire1")) {
            anim.SetTrigger("isShoot");
        }

        if (translation > 0)
        {
            anim.SetBool("isRun", true);
            anim.SetBool("isRunBack", false);
            anim.SetBool("isIdle", false);
        }
        else if (translation < 0)
        {
            anim.SetBool("isRunBack", true);
            anim.SetBool("isRun", false);
            anim.SetBool("isIdle", false);
        }
        else {
            anim.SetBool("isRunBack", false);
            anim.SetBool("isRun", false);
            anim.SetBool("isIdle", true);
        }

        if (Input.GetKeyDown("escape")) {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
