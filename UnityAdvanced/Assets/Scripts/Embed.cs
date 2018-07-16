using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embed : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.transform.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        EmbedArrow();
    }

    void EmbedArrow()
    {
        transform.GetComponent<ArrowSpawn>().enabled = false;
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        rb.isKinematic = true;
    }
}
