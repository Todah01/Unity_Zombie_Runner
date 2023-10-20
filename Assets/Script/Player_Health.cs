using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{
    [SerializeField] float playerHealth = 100f;

    public void TakeDamage(float damage){
        playerHealth = Mathf.Max(playerHealth - damage, 0f);
        if(playerHealth <= 0){
            GetComponent<Death_Handler>().HandleDeath();
        }
    }
}
