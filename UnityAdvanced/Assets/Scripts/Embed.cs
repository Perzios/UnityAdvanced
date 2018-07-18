using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embed : MonoBehaviour
{

    Rigidbody rb;

    public AudioClip Impact;
    public AudioSource source;

    bool embeded = false;

    void OnEnable()
    {
        rb = gameObject.transform.GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(rb.transform.position, rb.transform.forward, out hit, 0.6f) && embeded == false)
        {
            Destructible destroy = hit.transform.GetComponent<Destructible>();

            if (destroy != null)
            {
                destroy.breakObj();
            }

            embeded = true;

            EmbedArrow();
            transform.SetParent(hit.transform);
        }
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
        Destroy(gameObject, 7f);
        rb.isKinematic = false;
    }
}
