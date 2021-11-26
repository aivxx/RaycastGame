using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    Controls action;
    public static bool GamePaused = false;
    public Canvas PauseMenuUI;

    private void Awake()
    {
        action = new Controls();
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    private void Start()
    {
        action.Pause.Paused.performed += _ => DeterminePause();
        PauseMenuUI.enabled = false;
    }

    private void DeterminePause()
    {
        if (GamePaused)
            ResumeGame();
        else
            PauseGame();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        GamePaused = false;
        Cursor.visible = false;
        PauseMenuUI.enabled = false;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        AudioListener.pause = true;
        GamePaused = true;
        Cursor.visible = true;
        PauseMenuUI.enabled = true;

    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

}
