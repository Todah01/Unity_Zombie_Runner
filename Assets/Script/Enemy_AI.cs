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
    bool isProvoked = false;

    private void Start() {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    private void Update() {
        distanceToTarget = Vector3.Distance(target.position, this.transform.position);
        if(isProvoked){
            EngageTarget();
        }
        else if(distanceToTarget <= chaseRange){
            isProvoked = true;

            // navMeshAgent.SetDestination(target.position);
        }
    }

    private void EngageTarget()
    {
        if(distanceToTarget >= navMeshAgent.stoppingDistance){
            ChaseTarget();
            Debug.Log("Chase target");
        }

        if(distanceToTarget <= navMeshAgent.stoppingDistance){
            AttackTarget();
            Debug.Log("Attack target");
        }
    }
    private void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
    }

    private void AttackTarget()
    {
        GetComponent<Animator>().SetBool("attack", true);
        Debug.Log("Attack!");
    }

    void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
