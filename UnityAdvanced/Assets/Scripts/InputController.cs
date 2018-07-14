using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public float Vertical, Horizontal, Shoot;
    public Vector2 Mouseinput;
    public bool isJump;
    public bool isAim;
    public bool Equip = false, isEquip;
    public volatile bool isShoot;
    public GameObject bow;

    private void Awake()
    {
        bow = GameObject.FindGameObjectWithTag("Bow");
        bow.SetActive(false);
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
            //bow.SetActive(false);
        }
        else if (Equip == true)
        {
            StartCoroutine(Example(Equip));
            //bow.SetActive(true);
        }




        if (isAim && Input.GetButton("Fire1"))
        {
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
    }
}
