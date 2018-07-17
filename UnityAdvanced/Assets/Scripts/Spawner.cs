using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject cube, crate, bottle, flameCrate;
    public float cubeAmount, crateAmount, bottleAmount;

    void Awake()
    {
        for (int i = 0; i < cubeAmount; i++)
        {
            Vector3 spawnPosition = getVecCube();
            Instantiate(cube, spawnPosition, transform.rotation);
        }

        for (int i = 0; i < crateAmount; i++)
        {
            Vector3 spawnPosition = getVecCrateAndBottle();
            Instantiate(crate, spawnPosition, transform.rotation);
        }

        for (int i = 0; i < bottleAmount; i++)
        {
            Vector3 spawnPosition = getVecCrateAndBottle();
            Instantiate(bottle, spawnPosition, transform.rotation);
        }

        Vector3 spawn = getVecCrateAndBottle();
        Instantiate(flameCrate, spawn, transform.rotation);
    }

    private Vector3 getVecCube()
    {
        int ran = Random.Range(0, 4);
        if (ran == 0)
        {
            return new Vector3(Random.Range(-10f, -35f), Random.Range(2f, 10f), Random.Range(-10f, -35f));
        }
        else if (ran == 1)
        {
            return new Vector3(Random.Range(10f, 35f), Random.Range(2f, 10f), Random.Range(-10f, 35f));
        }
        else if (ran == 2)
        {
            return new Vector3(Random.Range(-10f, -5f), Random.Range(2f, 10f), Random.Range(5f, 35f));
        }
        else
        {
            return new Vector3(Random.Range(5f, 10f), Random.Range(2f, 10f), Random.Range(-5f, -35f));
        }
    }

    private Vector3 getVecCrateAndBottle()
    {
        int ran = Random.Range(0, 4);
        if (ran == 0)
        {
            return new Vector3(Random.Range(-10f, -35f), 0, Random.Range(-10f, -35f));
        }
        else if (ran == 1)
        {
            return new Vector3(Random.Range(10f, 35f), 0, Random.Range(-10f, 35f));
        }
        else if (ran == 2)
        {
            return new Vector3(Random.Range(-10f, -5f), 0, Random.Range(5f, 35f));
        }
        else
        {
            return new Vector3(Random.Range(5f, 10f), 0, Random.Range(-5f, -35f));
        }
    }

}
