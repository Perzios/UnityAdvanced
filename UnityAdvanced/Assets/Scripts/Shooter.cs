using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    
    public Transform spawn , arrow;
    
    private bool loaded = false;

	void Awake () {
	}
	
	// Update is called once per frame
	void Update () {
        if(GameManager.Instance.InputController.isAim && (Time.time >= GameManager.Instance.InputController.nextTimeToFire - 0.1f) && loaded == false) {
            Instantiate(arrow, spawn.position,spawn.rotation);
            loaded = true;
        }
        if (GameManager.Instance.InputController.isAim == false) {
            loaded = false;
        }
        if (GameManager.Instance.InputController.isShoot) {
            StartCoroutine(load());
        }
    }

    IEnumerator load()
    {
        yield return new WaitForSeconds(0.8f);
        loaded = false;
    }
}
