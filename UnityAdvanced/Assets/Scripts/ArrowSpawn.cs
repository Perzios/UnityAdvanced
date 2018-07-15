using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour {

    bool fired = false;

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.Instance.InputController.isShoot)
        {
            fired = true;
            transform.GetComponent<Rigidbody>().AddForce(transform.forward * 500f);
        }

        if (fired)
        {
            Destroy(gameObject, 10f);
        }
    }

    private void LateUpdate()
    {
        if (!fired) {
            transform.SetPositionAndRotation(GameManager.Instance.InputController.spawn.transform.position, GameManager.Instance.InputController.spawn.transform.rotation);
        }

        if (GameManager.Instance.InputController.isAim == false  && fired == false)
        {
            Destroy(gameObject, 0.01f);
        }
    }
}
