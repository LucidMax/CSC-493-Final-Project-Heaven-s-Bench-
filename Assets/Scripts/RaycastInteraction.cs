using UnityEngine;

/// <summary>
/// Raycasting system for object interaction and detection
/// Handles mouse clicks, object selection, and environmental queries
/// </summary>
public class RaycastInteraction : MonoBehaviour
{
    [Header("Raycast Settings")]
    [SerializeField] private float maxRayDistance = 100f;
    [SerializeField] private LayerMask interactableLayers;
    [SerializeField] private bool drawDebugRays = true;
    
    [Header("Visual Feedback")]
    [SerializeField] private Color hitColor = Color.green;
    [SerializeField] private Color missColor = Color.red;
    
    private Camera mainCamera;
    private RaycastHit lastHit;
    
    void Start()
    {
        mainCamera = Camera.main;
    }
    
    void Update()
    {
        HandleMouseInput();
    }
    
    void HandleMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PerformRaycast(Input.mousePosition);
        }
    }
    
    void PerformRaycast(Vector3 screenPosition)
    {
        Ray ray = mainCamera.ScreenPointToRay(screenPosition);
        
        if (Physics.Raycast(ray, out lastHit, maxRayDistance, interactableLayers))
        {
            OnRaycastHit(lastHit);
            
            if (drawDebugRays)
            {
                Debug.DrawRay(ray.origin, ray.direction * lastHit.distance, hitColor, 1.0f);
            }
        }
        else
        {
            OnRaycastMiss(ray);
            
            if (drawDebugRays)
            {
                Debug.DrawRay(ray.origin, ray.direction * maxRayDistance, missColor, 1.0f);
            }
        }
    }
    
    void OnRaycastHit(RaycastHit hit)
    {
        Debug.Log($"Raycast hit: {hit.collider.name} at {hit.point}");
        
        // Trigger any interaction on the hit object
        IInteractable interactable = hit.collider.GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactable.OnInteract();
        }
    }
    
    void OnRaycastMiss(Ray ray)
    {
        Debug.Log("Raycast missed all objects");
    }
    
    public RaycastHit GetLastHit()
    {
        return lastHit;
    }
    
    public bool CheckLineOfSight(Vector3 origin, Vector3 target, out RaycastHit hit)
    {
        Vector3 direction = target - origin;
        return Physics.Raycast(origin, direction.normalized, out hit, direction.magnitude, interactableLayers);
    }
}

/// <summary>
/// Interface for interactable objects
/// </summary>
public interface IInteractable
{
    void OnInteract();
}
