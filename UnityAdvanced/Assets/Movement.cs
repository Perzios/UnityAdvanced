using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 1. 8-Directional Movement.
/// 2. Stop and face current direction when input is absent.
/// </summary>
public class Movement : MonoBehaviour
{

    //////////////////////////////////////////////////////////////////////
    Rigidbody rb; // The Rigid Body Attached to the character.
    [SerializeField]
    float speed = 5;
    /////////////////////////////////////////////////////////////////////

    public float velocity = 5;
    public float turnSpeed = 10;

    Vector2 input;
    float angle;

    Quaternion targetRotation;
    Transform cam;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        cam = Camera.main.transform;

    }

    void Update()
    {
        GetInput();

        if (Mathf.Abs(input.x) < 1 && Mathf.Abs(input.y) < 1) return;

        CalculateDirection();
        Rotate();
        Move();
    }

    /// <summary>
    /// Input based on Horizontal(a,d,h,j) and Vertical (w,s,u,n) keys.
    /// </summary>
    void GetInput()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

    }

    ///<summary>
    ///Direction relative to the cameras rotation.
    /// </summary>
    void CalculateDirection()
    {
        if (input.y >= 0) { }
        angle = Mathf.Atan2(input.x, input.y);
        angle = Mathf.Rad2Deg * angle;
        angle += cam.eulerAngles.y;
    }

    ///<summary>
    ///Rotate toward the calculated direction.
    /// </summary>
    void Rotate()
    {
        targetRotation = Quaternion.Euler(0, angle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }

    ///<summary>
    ///This player only moves along its own forward axis.
    /// </summary>
    void Move()
    {
        rb.velocity = transform.forward * speed; // Add velocity in the forward direction.
    }
}