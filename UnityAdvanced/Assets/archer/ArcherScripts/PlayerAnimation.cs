using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    Animator animator;

    public bool eq = false;

    private PlayerAim m_PlayerAim;
    private PlayerAim PlayerAim {
        get {
            if (m_PlayerAim == null) {
                m_PlayerAim = GameManager.Instance.LocalPlayer.playerAim;
            }
            return m_PlayerAim;
        }
    }

	void Awake () {
        animator = GetComponentInChildren<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        animator.SetFloat("Vertical", GameManager.Instance.InputController.Vertical);
        animator.SetFloat("Horizontal", GameManager.Instance.InputController.Horizontal);
        animator.SetBool("isJump", GameManager.Instance.InputController.isJump);
        animator.SetBool("isAim", GameManager.Instance.InputController.isAim);
        animator.SetBool("Shoot", GameManager.Instance.InputController.isShoot);
        animator.SetBool("isEquip", GameManager.Instance.InputController.isEquip);

        if (GameManager.Instance.InputController.Equip == true && eq == false)
        {
            eq = true;
            animator.SetBool("isEquip", true);
            animator.SetFloat("Equip", -1.0f);
        }
        else if (GameManager.Instance.InputController.Equip == false && eq == true)
        {
            eq = false;
            animator.SetBool("isEquip", true);
            animator.SetFloat("Equip", 1.0f);
        }

        

        if (GameManager.Instance.InputController.isAim)
        {
            animator.SetFloat("AimAngle", PlayerAim.getAngle());
            if (GameManager.Instance.InputController.isShoot) {
                animator.SetFloat("isShoot", 0);
            }
        }
        else {
            animator.SetFloat("Equip", 0.0f);
            animator.SetFloat("AimAngle", 0.0f);
        }
        
    }
}
