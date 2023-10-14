using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;

    private void Start() {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        distanceToTarget = Vector3.Distance(target.position, this.transform.position);
        if(distanceToTarget <= chaseRange){
            navMeshAgent.SetDestination(target.position);
        }
        else{
            
        }
    }
}
