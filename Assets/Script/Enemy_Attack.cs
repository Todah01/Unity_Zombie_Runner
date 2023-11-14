using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    Player_Health target;
    [SerializeField] float damage = 40f;

    void Start(){
        target = FindObjectOfType<Player_Health>();
    }

    public void AttackHitEvent(){
        if(target == null) return;
        target.TakeDamage(damage);
        target.GetComponent<DisplayDamage>().ShowDamageImpact();
    }    
}
