# Contributing to Heaven's Bench

Thank you for your interest in contributing to Heaven's Bench! This guide will help you get started.

## Development Workflow

### Setting Up Development Environment

1. **Clone and Open Project**
   ```bash
   git clone https://github.com/LucidMax/CSC-493-Final-Project-Heaven-s-Bench-.git
   cd CSC-493-Final-Project-Heaven-s-Bench-
   ```

2. **Unity Editor Setup**
   - Install Unity Hub
   - Install Unity 2021.3.0f1 or compatible version
   - Open project in Unity Hub

3. **Configure Git**
   ```bash
   git config user.name "Your Name"
   git config user.email "your.email@example.com"
   ```

### Making Changes

1. **Create Feature Branch**
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Make Your Changes**
   - Edit scripts in `Assets/Scripts/`
   - Modify scenes in `Assets/Scenes/`
   - Add assets to appropriate folders

3. **Test Your Changes**
   - Test in TestingScene first
   - Verify no errors in Console
   - Test in target scene
   - Check performance

4. **Commit Changes**
   ```bash
   git add .
   git commit -m "Add: brief description of changes"
   ```

### Code Style Guidelines

#### C# Scripts
- Use PascalCase for class and method names
- Use camelCase for private fields
- Prefix private fields with underscore (optional)
- Add XML documentation comments
- Follow Unity C# conventions

Example:
```csharp
/// <summary>
/// Brief description of the class
/// </summary>
public class MyNewScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Transform targetTransform;
    
    /// <summary>
    /// Brief description of method
    /// </summary>
    public void DoSomething()
    {
        // Implementation
    }
}
```

#### Scene Organization
- Use empty GameObjects as folders
- Name objects descriptively
- Group related objects under parent
- Use prefabs for reusable objects

### Commit Message Guidelines

Use clear, descriptive commit messages:

- `Add: New feature or file`
- `Update: Modified existing feature`
- `Fix: Bug fix`
- `Refactor: Code restructuring`
- `Docs: Documentation changes`
- `Test: Test-related changes`

Examples:
```
Add: Procedural water mesh generator
Update: NavMesh controller movement speed
Fix: Ragdoll physics initialization bug
Refactor: Collision detection system
Docs: Update README with setup instructions
```

### Pull Request Process

1. **Update Documentation**
   - Update README.md if needed
   - Add comments to new scripts
   - Update relevant docs in Assets folders

2. **Test Thoroughly**
   - All scenes load without errors
   - Scripts compile successfully
   - No console errors or warnings
   - Performance is acceptable

3. **Create Pull Request**
   - Describe changes clearly
   - Reference related issues
   - Add screenshots if UI changes
   - Request review from team

4. **Address Review Feedback**
   - Make requested changes
   - Push updates to same branch
   - Re-request review

## File Organization

### Scripts
- Place in `Assets/Scripts/`
- Create subfolder for related systems
- One class per file
- Match filename to class name

### Scenes
- Save in `Assets/Scenes/`
- Use descriptive names
- Document purpose in scene README

### Assets
- **Materials**: `Assets/Materials/`
- **Prefabs**: `Assets/Prefabs/`
- **Models**: `Assets/Models/`
- Sort by feature or system

## Common Tasks

### Adding NavMesh to Scene
1. Select all static geometry
2. Mark as "Navigation Static" in Inspector
3. Window > AI > Navigation
4. Bake > Bake
5. Test with NavMeshAgent

### Creating Ragdoll
1. Select character model
2. GameObject > 3D Object > Ragdoll...
3. Assign body parts in wizard
4. Attach RagdollPhysics.cs script
5. Configure rigidbody properties

### Generating Procedural Mesh
1. Create empty GameObject
2. Add ProceduralMeshGenerator.cs
3. Add MeshRenderer component
4. Configure mesh type and parameters
5. Assign material to MeshRenderer

## Debugging Tips

### Common Issues

**Scripts not compiling:**
- Check for syntax errors in Console
- Verify all using statements
- Check for missing semicolons

**NavMesh agent not moving:**
- Verify NavMesh is baked
- Check agent is on NavMesh (isOnNavMesh)
- Verify destination is reachable

**Physics not working:**
- Check Rigidbody component present
- Verify colliders are configured
- Check layer collision matrix

### Unity Console
- Double-click errors to jump to code
- Check warning messages
- Use Debug.Log() for debugging
- Enable Pause on Error for breakpoints

## Resources

### Unity Documentation
- [Unity Manual](https://docs.unity3d.com/Manual/index.html)
- [Unity Scripting API](https://docs.unity3d.com/ScriptReference/index.html)
- [Unity Learn](https://learn.unity.com/)

### Project Resources
- [Main README](README.md)
- [Scripts Documentation](Assets/Scripts/README.md)
- [Scenes Documentation](Assets/Scenes/README.md)

## Questions?

If you have questions or need help:
- Check existing documentation
- Review Unity Manual
- Ask in project discussions
- Open an issue for bugs

---

Thank you for contributing to Heaven's Bench!
