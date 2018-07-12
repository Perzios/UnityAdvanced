using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]

public class Player : MonoBehaviour {

    [System.Serializable]
    public class MouseInput {
        public Vector2 Damping;
        public Vector2 Sensitivity;
    }

    Vector2 mouseI;

    [SerializeField]
    float runSpeed;
    [SerializeField]
    float Aimspeed;
    [SerializeField]
    MouseInput MouseControl;

    public PlayerAim playerAim;

    private MoveController m_MoveController;
    public MoveController MoveController {
        get {
            if (m_MoveController == null) {
                m_MoveController = GetComponent<MoveController>();
            }
            return m_MoveController;
        }
    }

    InputController playerInput;
    
	void Awake () {
        playerInput = GameManager.Instance.InputController;
        GameManager.Instance.LocalPlayer = this;
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update () {
        float moveSpeed = runSpeed;

        if (playerInput.isAim) {
            moveSpeed = Aimspeed;
        }

        mouseI = GameManager.Instance.InputController.Mouseinput;

        Vector2 dir = new Vector2(playerInput.Vertical * moveSpeed, playerInput.Horizontal * moveSpeed);
        MoveController.Move(dir);

        playerAim.setRotation(mouseI.y * MouseControl.Sensitivity.y);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
