using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_Handler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    private void Start() {
        gameOverCanvas.enabled = false;
    }

    public void HandleDeath(){
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<Weapon_Switcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
