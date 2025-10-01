# Prefabs

This directory contains reusable Unity prefabs for the project.

## What are Prefabs?

Prefabs are reusable GameObject templates that can be instantiated multiple times in scenes. They maintain a connection to their source, allowing batch updates.

## Prefab Categories

### Characters
- Player characters
- NPC agents
- Enemy entities
- Include: Model, Scripts, Colliders, Rigidbody

### Environment
- Trees, rocks, vegetation
- Buildings and structures
- Terrain decorations
- Optimized for performance

### Effects
- Particle systems
- Visual effects
- Audio sources
- Temporary objects

### UI Elements
- Menus and HUD
- Buttons and panels
- Health bars
- Interaction prompts

### Interactive Objects
- Doors, switches, triggers
- Collectible items
- Interactable props
- Include CollisionDetector script

## Creating Prefabs

1. Build GameObject in scene
2. Configure all components
3. Test functionality
4. Drag to Prefabs folder
5. Name with prefix (e.g., `Pfb_TreePine`)

## Using Prefabs

### In Editor
- Drag from Project to Scene
- Configure instance-specific values
- Modifications appear in blue

### From Script
```csharp
[SerializeField] private GameObject prefab;

void SpawnObject()
{
    Instantiate(prefab, position, rotation);
}
```

## Prefab Best Practices

- Keep prefabs modular and reusable
- Use nested prefabs for complex objects
- Override properties at instance level
- Update prefab for global changes
- Test after prefab modifications

## Prefab Variants

Create variants for similar objects:
1. Right-click prefab
2. Create > Prefab Variant
3. Modify variant properties
4. Maintains base prefab connection

## Common Prefabs to Create

- [ ] AI Agent with NavMeshController
- [ ] Ragdoll Character
- [ ] Procedural Terrain Chunk
- [ ] Interactive Object Base
- [ ] Particle Effect Collection
- [ ] UI Canvas Template
