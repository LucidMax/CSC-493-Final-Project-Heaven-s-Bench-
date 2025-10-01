# Scripts Documentation

This directory contains all gameplay scripts for Heaven's Bench project.

## Core Scripts

### NavMeshController.cs
**Purpose**: AI pathfinding and navigation  
**Dependencies**: UnityEngine.AI namespace  
**Key Methods**:
- `SetDestination(Vector3)` - Direct position targeting
- `SetTarget(Transform)` - Follow moving target
- `HasReachedDestination()` - Check arrival status

**Usage**: Attach to AI agent GameObjects with NavMeshAgent component.

### RaycastInteraction.cs
**Purpose**: Mouse-based object interaction  
**Dependencies**: Camera, Physics system  
**Key Methods**:
- `PerformRaycast(Vector3)` - Cast ray from screen position
- `CheckLineOfSight(Vector3, Vector3)` - Check visibility between points

**Usage**: Attach to a manager GameObject in scene.

### CollisionDetector.cs
**Purpose**: Physics collision event handling  
**Dependencies**: Collider component  
**Key Features**:
- Layer mask filtering
- Unity Events for collision callbacks
- Collision count tracking

**Usage**: Attach to any GameObject that needs collision detection.

### RagdollPhysics.cs
**Purpose**: Dynamic ragdoll physics system  
**Dependencies**: Rigidbody, Animator  
**Key Methods**:
- `EnableRagdoll()` - Switch to physics mode
- `DisableRagdoll()` - Return to animation mode
- `ApplyForce(Vector3, Vector3)` - Apply impact forces

**Usage**: Attach to character root with configured ragdoll hierarchy.

### ProceduralMeshGenerator.cs
**Purpose**: Runtime mesh generation  
**Dependencies**: MeshFilter, MeshRenderer  
**Mesh Types**:
- Plane - Flat grid mesh
- Terrain - Height-mapped surface
- Cube - Basic primitive
- Sphere - Icosphere subdivision

**Usage**: Attach to empty GameObject to generate mesh at runtime.

## Integration Examples

### AI Navigation Setup
```csharp
NavMeshController aiController = GetComponent<NavMeshController>();
aiController.SetDestination(targetPosition);
```

### Raycast Interaction
```csharp
RaycastInteraction raycast = FindObjectOfType<RaycastInteraction>();
RaycastHit hit = raycast.GetLastHit();
```

### Collision Handling
```csharp
CollisionDetector detector = GetComponent<CollisionDetector>();
detector.onCollisionEnterEvent.AddListener(OnCollisionDetected);
```

## Best Practices

1. **Performance**: Use object pooling for frequently instantiated objects
2. **Events**: Subscribe to Unity Events in OnEnable, unsubscribe in OnDisable
3. **Null Checks**: Always check for null references before accessing components
4. **Debug Logs**: Use conditional compilation for debug statements in production

## Adding New Scripts

1. Create script file in this directory
2. Follow C# naming conventions (PascalCase)
3. Add XML documentation comments
4. Include usage examples in comments
5. Update this README with script description
