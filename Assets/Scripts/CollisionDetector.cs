using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Advanced collision detection system with event callbacks
/// Handles collision enter, stay, and exit events with filtering
/// </summary>
[RequireComponent(typeof(Collider))]
public class CollisionDetector : MonoBehaviour
{
    [Header("Collision Settings")]
    [SerializeField] private bool detectCollisions = true;
    [SerializeField] private bool detectTriggers = true;
    [SerializeField] private LayerMask collisionLayers;
    
    [Header("Collision Events")]
    public UnityEvent<Collision> onCollisionEnterEvent;
    public UnityEvent<Collision> onCollisionExitEvent;
    public UnityEvent<Collider> onTriggerEnterEvent;
    public UnityEvent<Collider> onTriggerExitEvent;
    
    [Header("Debug")]
    [SerializeField] private bool logCollisions = true;
    
    private int collisionCount = 0;
    
    void OnCollisionEnter(Collision collision)
    {
        if (!detectCollisions) return;
        
        if (IsInLayerMask(collision.gameObject.layer))
        {
            collisionCount++;
            
            if (logCollisions)
            {
                Debug.Log($"Collision Enter: {gameObject.name} hit {collision.gameObject.name}");
                Debug.Log($"Impact force: {collision.impulse.magnitude}");
                Debug.Log($"Contact points: {collision.contactCount}");
            }
            
            onCollisionEnterEvent?.Invoke(collision);
            HandleCollisionEnter(collision);
        }
    }
    
    void OnCollisionStay(Collision collision)
    {
        if (!detectCollisions) return;
        
        if (IsInLayerMask(collision.gameObject.layer))
        {
            HandleCollisionStay(collision);
        }
    }
    
    void OnCollisionExit(Collision collision)
    {
        if (!detectCollisions) return;
        
        if (IsInLayerMask(collision.gameObject.layer))
        {
            collisionCount--;
            
            if (logCollisions)
            {
                Debug.Log($"Collision Exit: {gameObject.name} separated from {collision.gameObject.name}");
            }
            
            onCollisionExitEvent?.Invoke(collision);
            HandleCollisionExit(collision);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (!detectTriggers) return;
        
        if (IsInLayerMask(other.gameObject.layer))
        {
            if (logCollisions)
            {
                Debug.Log($"Trigger Enter: {gameObject.name} entered {other.gameObject.name}");
            }
            
            onTriggerEnterEvent?.Invoke(other);
            HandleTriggerEnter(other);
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (!detectTriggers) return;
        
        if (IsInLayerMask(other.gameObject.layer))
        {
            if (logCollisions)
            {
                Debug.Log($"Trigger Exit: {gameObject.name} exited {other.gameObject.name}");
            }
            
            onTriggerExitEvent?.Invoke(other);
            HandleTriggerExit(other);
        }
    }
    
    protected virtual void HandleCollisionEnter(Collision collision) { }
    protected virtual void HandleCollisionStay(Collision collision) { }
    protected virtual void HandleCollisionExit(Collision collision) { }
    protected virtual void HandleTriggerEnter(Collider other) { }
    protected virtual void HandleTriggerExit(Collider other) { }
    
    private bool IsInLayerMask(int layer)
    {
        return (collisionLayers.value & (1 << layer)) != 0;
    }
    
    public int GetActiveCollisionCount()
    {
        return collisionCount;
    }
}
