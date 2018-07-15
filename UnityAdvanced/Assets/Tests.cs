using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tests : MonoBehaviour {

    public Transform arrow;


	void Start () {
        Instantiate(arrow, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        Instantiate(arrow, transform.position, transform.rotation);
    }
}
