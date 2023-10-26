using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;

    public bool IsDead(){
        return isDead;
    }

    public void TakeDamage(float damage){
        BroadcastMessage("OnDamageTaken", SendMessageOptions.DontRequireReceiver);
        hitPoints = Mathf.Max(hitPoints - damage, 0);
        if(hitPoints <= 0){
            Die();
        }
    }

    private void Die()
    {
        if(isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }
}
