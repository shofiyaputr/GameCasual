using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public string EnterScene;
    public string EscapeScene;
    public bool isEscapeForQuit = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Name Scene: " + EnterScene);
            SceneManager.LoadScene(EnterScene);
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isEscapeForQuit)
            {
                Application.Quit();
            }
            else
            {
                Debug.Log("Name Scene: " + EscapeScene);
                SceneManager.LoadScene(EscapeScene);
            }
        }
    }
}
