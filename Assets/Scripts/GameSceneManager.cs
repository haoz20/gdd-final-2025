using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMadDriverClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void OnFlyLikeBirdClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void OnSumoAndBallClicked()
    {
        SceneManager.LoadScene(2);
    }

    public void OnExitClicked()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
