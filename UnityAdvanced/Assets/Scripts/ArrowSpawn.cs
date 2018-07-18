using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{

    bool fired = false;

    Rigidbody rb;

    void Awake()
    {
        rb = gameObject.transform.GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (GameManager.Instance.InputController.isShoot && !fired)
        {
            fired = true;
            gameObject.transform.GetComponent<Embed>().enabled = true;
            rb.useGravity = true;
            rb.velocity = Vector3.zero;
            rb.AddRelativeForce(Vector3.forward * 1500f);
        }
    }

    void arrowDrop()
    {
        float yVelocity = rb.velocity.y;
        float zVelocity = rb.velocity.z;
        float xVelocity = rb.velocity.x;
        float comVelocity = Mathf.Sqrt(xVelocity * xVelocity + zVelocity * zVelocity);
        float fallAngle = -1 * Mathf.Atan2(yVelocity, comVelocity) * 180 / Mathf.PI;

        transform.eulerAngles = new Vector3(fallAngle, transform.eulerAngles.y, transform.eulerAngles.x);
    }



    private void LateUpdate()
    {
        //Reposition to correct location on bow if the arrow has not yet been fired
        if (!fired)
        {
            transform.SetPositionAndRotation(GameManager.Instance.InputController.spawn.transform.position, GameManager.Instance.InputController.spawn.transform.rotation);
        }
        //Destroys arrow if player exits aim mode
        if (GameManager.Instance.InputController.isAim == false && fired == false)
        {
            Destroy(gameObject, 0.01f);
        }
    }
}
