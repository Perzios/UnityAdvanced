using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embed : MonoBehaviour {

    Rigidbody rb;

    public AudioClip Impact;
    public AudioSource source;

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
        source.PlayOneShot(Impact);
        transform.GetComponent<ArrowSpawn>().enabled = false;
        //transform.GetComponentInChildren(ParticleAnimator).enabled = false;
        transform.GetComponentInChildren<FlameAudio>().StopPlay();
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        rb.isKinematic = true;
        Destroy(gameObject, 5f);
    }
}
