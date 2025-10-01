using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// NavMesh AI pathfinding controller for autonomous agent navigation
/// Enables NPCs to navigate complex terrain using Unity's NavMesh system
/// </summary>
[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshController : MonoBehaviour
{
    [Header("Navigation Settings")]
    [SerializeField] private Transform targetDestination;
    [SerializeField] private float updateInterval = 0.5f;
    [SerializeField] private float stoppingDistance = 1.5f;
    
    [Header("Movement Parameters")]
    [SerializeField] private float moveSpeed = 3.5f;
    [SerializeField] private float rotationSpeed = 120f;
    [SerializeField] private float acceleration = 8f;
    
    private NavMeshAgent agent;
    private float nextUpdateTime;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        ConfigureAgent();
    }
    
    void ConfigureAgent()
    {
        agent.speed = moveSpeed;
        agent.angularSpeed = rotationSpeed;
        agent.acceleration = acceleration;
        agent.stoppingDistance = stoppingDistance;
    }
    
    void Update()
    {
        if (targetDestination != null && Time.time >= nextUpdateTime)
        {
            UpdateDestination();
            nextUpdateTime = Time.time + updateInterval;
        }
    }
    
    void UpdateDestination()
    {
        if (agent.isOnNavMesh)
        {
            agent.SetDestination(targetDestination.position);
        }
    }
    
    public void SetDestination(Vector3 destination)
    {
        if (agent.isOnNavMesh)
        {
            agent.SetDestination(destination);
        }
    }
    
    public void SetTarget(Transform target)
    {
        targetDestination = target;
    }
    
    public bool HasReachedDestination()
    {
        return !agent.pathPending && agent.remainingDistance <= agent.stoppingDistance;
    }
}
