using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager{

    private GameObject gObject;

    private static GameManager m_Instance;

    public static GameManager Instance {
        get {
            if (m_Instance == null) {
                m_Instance = new GameManager();
                m_Instance.gObject = new GameObject("_gameManager");
                m_Instance.gObject.AddComponent<InputController>();
            }
            return m_Instance;
        }
    }

    private InputController m_InputController;
    public InputController InputController {
        get {
            if (m_InputController == null) {
                m_InputController = gObject.GetComponent<InputController>();
            }
            return m_InputController;
        }
    }

}
