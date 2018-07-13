using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowPosition : MonoBehaviour {

    [SerializeField]
    Transform hand;


    void Awake()
    {
        transform.SetParent(hand);
    }
}
