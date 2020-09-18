using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMotion : MonoBehaviour
{
    [SerializeField] Transform target;

    private NavMeshAgent navMeshAgent = null;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

   

    private void Start()
    {
        navMeshAgent.SetDestination(target.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        navMeshAgent.SetDestination(target.transform.position);
    }

    public void SetTarget(Transform target)
    {
        
        navMeshAgent.SetDestination(target.position);
    }
}
