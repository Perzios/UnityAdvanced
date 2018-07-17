using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject cube;
    
	void Awake () {
        for (int i = 0; i < 50; i++) {
            Vector3 spawnPosition = getVec();
            Instantiate(cube, spawnPosition, transform.rotation);
        }
	}

    private Vector3 getVec(){
        int ran = Random.Range(0, 4);
        if (ran == 0)
        {
            return new Vector3(Random.Range(-10f, -35f), Random.Range(0f, 10f), Random.Range(-10f, -35f));
        }
        else if (ran == 1)
        {
            return new Vector3(Random.Range(10f, 35f), Random.Range(0f, 10f), Random.Range(-10f, 35f));
        }
        else if (ran == 2)
        {
            return new Vector3(Random.Range(-10f, -5f), Random.Range(0f, 10f), Random.Range(5f, 35f));
        }
        else
        {
            return new Vector3(Random.Range(5f, 10f), Random.Range(0f, 10f), Random.Range(-5f, -35f));
        }
    }
	
}
