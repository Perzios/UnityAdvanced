using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public float Vertical, Horizontal, Shoot , rate = 0.6f;
    public Vector2 Mouseinput;
    public bool isJump;
    public bool isAim;
    public bool Equip = false, isEquip;
    public volatile bool isShoot;
    public GameObject bow, backBow , spawn;

    public float nextTimeToFire = 0f; 

    private void Awake()
    {
        bow = GameObject.FindGameObjectWithTag("Bow");
        spawn = GameObject.FindGameObjectWithTag("Launch");
        bow.SetActive(false);        

        backBow = GameObject.FindGameObjectWithTag("Back");
        backBow.SetActive(true);
    }

    void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        Mouseinput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        isJump = Input.GetButton("Jump");
        isAim = Input.GetButton("Fire2");

        if (!isAim) {
            isEquip = Input.GetButtonDown("Equip");
        }

        if (isEquip && Equip == false)
        {
            Equip = true;
        }
        else if (isEquip && Equip == true)
        {
            Equip = false;
        }
        else if (isAim)
        {
            Equip = true;
        }

        if (Equip == false && isAim != true)
        {
            StartCoroutine(Example(Equip));
        }
        else if (Equip == true)
        {
            StartCoroutine(Example(Equip));
        }




        if (isAim && Input.GetButtonUp("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f/rate;
            isShoot = true;
        }
        else
        {
            isShoot = false;
        }
    }

    IEnumerator Example(bool choose)
    {
        yield return new WaitForSecondsRealtime(0.5f);
        bow.SetActive(choose);
        backBow.SetActive(!choose);
    }
}
