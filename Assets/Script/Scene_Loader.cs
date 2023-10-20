using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Loader : MonoBehaviour
{
    public UnityEvent PlayAgainEvent;
    public UnityEvent QuitEvent;
    public void OnClickPlayAgainButton(){
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void OnClickQuitButton(){
        Time.timeScale = 1;
        Application.Quit();
    }
}
