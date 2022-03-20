using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
    public GameObject Text;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Resume: " + PauseMenuUI.name);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        gameObject.GetComponent<StarterAssets.StarterAssetsInputs > ().cursorInputForLook = true;
        Text.SetActive(true);
    }

    void Paused()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("Paused: " + PauseMenuUI.name);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Text.SetActive(false);
    }
}