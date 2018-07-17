using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embed : MonoBehaviour
{

    Rigidbody rb;
    Transform gb;

    public AudioClip Impact;
    public AudioSource source;

    bool embeded = false;

    // Use this for initialization
    void OnEnable()
    {
        rb = gameObject.transform.GetComponent<Rigidbody>();
        gb = gameObject.transform.Find("caster");
    }

    // Update is called once per frame
   /* void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(gb.transform.position, gb.transform.forward, out hit, 0.1f) && embeded == false)
        {
            embeded = true;
            Debug.Log(hit.transform.name);
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            rb.useGravity = false;
            transform.SetParent(hit.transform);

            EmbedArrow();
            
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        EmbedArrow();
        transform.SetParent(other.transform);
    }

    void EmbedArrow()
    {
        source.PlayOneShot(Impact);
        transform.GetComponent<ArrowSpawn>().enabled = false;
        transform.GetComponentInChildren<ParticleSystem>().Stop();
        transform.GetComponentInChildren<FlameAudio>().StopPlay();
        rb.velocity = Vector3.zero;
        rb.isKinematic = true;
        rb.useGravity = false;
        Destroy(gameObject, 5f);
        rb.isKinematic = false;
    }
}
