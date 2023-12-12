using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Transform player;

    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (player == null)
        {
            player = GameObject.FindWithTag("Player").transform;
        }

        if (navMeshAgent == null)
        {
            Debug.LogError("NavMeshAgent component not found on enemy.");
        }
    }

    void Update()
    {
        if (player != null)
        {
            MoveTowardsPlayer();
        }
    }

    void MoveTowardsPlayer()
    {
        navMeshAgent.SetDestination(player.position);
    }
}