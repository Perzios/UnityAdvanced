using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowPosition : MonoBehaviour {

    [SerializeField]
    Transform hand;

    [SerializeField]
    Transform bow;


    void Awake()
    {      
            //transform.SetParent(hand);
            //transform.position = hand.transform.position;        
    }

    private void LateUpdate()
    {
        if (GameManager.Instance.InputController.isAim && !GameManager.Instance.InputController.isShoot)
        {
            transform.SetParent(hand);
            transform.position = hand.transform.position;
        }
    }
}
