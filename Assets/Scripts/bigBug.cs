using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bigBug : MonoBehaviour
{

    private NavMeshAgent agent;
    private GameObject target;

    private float distanceToTarget;

    public float attackRange;

    bool isAttacking;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<Player>().gameObject;
        agent.SetDestination(target.transform.position);
    }


    private void GetDistanceToTarget()
    {
        distanceToTarget = Vector3.Distance(transform.position, target.transform.position);
    }
    // Update is called once per frame
    void Update()
    {
        GetDistanceToTarget();

        if (!isAttacking)
        {
            if (distanceToTarget <= attackRange)
            {
                // Attack
            }
            else
            {
                // Pursue
                agent.SetDestination(target.transform.position);
            }
        }
    }

    private void Attack()
    {

    }


    private void Pursue()
    {

    }
}
