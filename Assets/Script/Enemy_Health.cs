using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage){
        hitPoints = Mathf.Max(hitPoints - damage, 0);
        if(hitPoints <= 0){
            Destroy(gameObject);
        }
    }
}
