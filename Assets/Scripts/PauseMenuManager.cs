using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private string mainMenuSceneName = "MainMenu";

    private bool isPaused = false;

    void Start()
    {
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(false);
    }

    void Update()
    {
        // Toggle pause with Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Freeze game
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Resume game
        isPaused = false;
        Debug.Log("ResumeGame called, isPaused set to " + isPaused);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }

}

