using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    public float angularVelocity = 10.0f;
    public float speed;   // Rotation speed
    private Vector3 axisOfRotation;   // Rotation angle

    private void Start()
    {
        axisOfRotation = Random.onUnitSphere;
        speed =  Random.Range(1f, 10f); 
    }

    void Update()
	{
        //Note how deltatime is used here (Hint: not in FixedUpdate!)
        //transform.Rotate(new Vector3(15f,30f,45f)*Time.deltaTime);
        transform.Rotate(axisOfRotation , angularVelocity * Time.smoothDeltaTime * speed);
	}
}
