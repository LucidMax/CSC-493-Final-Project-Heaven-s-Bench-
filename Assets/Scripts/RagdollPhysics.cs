using UnityEngine;

/// <summary>
/// Ragdoll physics controller for realistic character animations
/// Manages transition between animated and physics-based states
/// </summary>
public class RagdollPhysics : MonoBehaviour
{
    [Header("Ragdoll Settings")]
    [SerializeField] private bool startAsRagdoll = false;
    [SerializeField] private float activationForce = 10f;
    [SerializeField] private float transitionSpeed = 5f;
    
    [Header("Ragdoll Parts")]
    [SerializeField] private Transform ragdollRoot;
    
    private Rigidbody[] ragdollRigidbodies;
    private Collider[] ragdollColliders;
    private Animator animator;
    private bool isRagdollActive = false;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        InitializeRagdoll();
        
        if (startAsRagdoll)
        {
            EnableRagdoll();
        }
        else
        {
            DisableRagdoll();
        }
    }
    
    void InitializeRagdoll()
    {
        // Find all rigidbodies in children (ragdoll parts)
        ragdollRigidbodies = GetComponentsInChildren<Rigidbody>();
        ragdollColliders = GetComponentsInChildren<Collider>();
        
        Debug.Log($"Initialized ragdoll with {ragdollRigidbodies.Length} rigidbodies");
    }
    
    public void EnableRagdoll()
    {
        if (isRagdollActive) return;
        
        isRagdollActive = true;
        
        // Disable animator
        if (animator != null)
        {
            animator.enabled = false;
        }
        
        // Enable all ragdoll rigidbodies
        foreach (Rigidbody rb in ragdollRigidbodies)
        {
            rb.isKinematic = false;
            rb.detectCollisions = true;
        }
        
        // Enable all ragdoll colliders
        foreach (Collider col in ragdollColliders)
        {
            col.enabled = true;
        }
        
        Debug.Log("Ragdoll enabled");
    }
    
    public void DisableRagdoll()
    {
        if (!isRagdollActive) return;
        
        isRagdollActive = false;
        
        // Enable animator
        if (animator != null)
        {
            animator.enabled = true;
        }
        
        // Disable all ragdoll rigidbodies
        foreach (Rigidbody rb in ragdollRigidbodies)
        {
            rb.isKinematic = true;
            rb.detectCollisions = false;
        }
        
        // Disable colliders except main character controller
        foreach (Collider col in ragdollColliders)
        {
            // Keep the main collider enabled
            if (col.gameObject == gameObject)
                continue;
            col.enabled = false;
        }
        
        Debug.Log("Ragdoll disabled");
    }
    
    public void ApplyForce(Vector3 force, Vector3 position)
    {
        if (!isRagdollActive)
        {
            EnableRagdoll();
        }
        
        // Apply force to the nearest rigidbody
        Rigidbody closestRb = GetClosestRigidbody(position);
        if (closestRb != null)
        {
            closestRb.AddForceAtPosition(force, position, ForceMode.Impulse);
        }
    }
    
    public void ApplyExplosionForce(float force, Vector3 position, float radius)
    {
        if (!isRagdollActive)
        {
            EnableRagdoll();
        }
        
        foreach (Rigidbody rb in ragdollRigidbodies)
        {
            rb.AddExplosionForce(force, position, radius, 1f, ForceMode.Impulse);
        }
    }
    
    private Rigidbody GetClosestRigidbody(Vector3 position)
    {
        Rigidbody closest = null;
        float minDistance = float.MaxValue;
        
        foreach (Rigidbody rb in ragdollRigidbodies)
        {
            float distance = Vector3.Distance(rb.position, position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closest = rb;
            }
        }
        
        return closest;
    }
    
    public bool IsRagdollActive()
    {
        return isRagdollActive;
    }
    
    void Update()
    {
        // Toggle ragdoll with R key for testing
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRagdollActive)
                DisableRagdoll();
            else
                EnableRagdoll();
        }
    }
}
