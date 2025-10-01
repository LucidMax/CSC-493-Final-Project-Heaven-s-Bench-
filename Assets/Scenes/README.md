# Scene Documentation

This directory contains all Unity scene files for Heaven's Bench project.

## Available Scenes

### TestingScene.unity
**Purpose**: Development and testing environment  
**Features**:
- Basic lighting setup
- Camera configuration
- Empty space for testing components
- Ideal for script prototyping

**Use Cases**:
- Testing new scripts
- Debugging physics interactions
- Prototyping gameplay mechanics
- Performance testing

### IslandScene.unity
**Purpose**: Island environment with natural elements  
**Features**:
- Enhanced atmospheric lighting
- Fog effects for depth perception
- Elevated camera for overview
- Ocean-themed ambient settings
- Terrain suitable for NavMesh

**Use Cases**:
- AI navigation testing
- Terrain interaction
- Ocean shader development
- Environmental atmosphere testing

### GameScene.unity
**Purpose**: Main gameplay and integration scene  
**Features**:
- Standard game lighting
- Fog for atmospheric depth
- Balanced settings for gameplay
- All systems integration point

**Use Cases**:
- Final gameplay testing
- System integration
- Performance optimization
- Full feature demonstration

## Scene Setup Guidelines

### Adding NavMesh
1. Select static geometry
2. Window > AI > Navigation
3. Click "Bake" tab
4. Configure agent settings
5. Click "Bake" button

### Lighting Setup
1. Window > Rendering > Lighting
2. Configure Skybox Material
3. Set Ambient Source
4. Adjust fog settings
5. Bake lightmaps (optional)

### Camera Configuration
- Position: Depends on scene scale
- Field of View: 60° (default)
- Clipping Planes: Near 0.3, Far 1000
- Add AudioListener component

## Scene Loading

### From Script
```csharp
using UnityEngine.SceneManagement;

SceneManager.LoadScene("TestingScene");
```

### Build Settings
1. File > Build Settings
2. Drag scenes into "Scenes In Build"
3. Reorder as needed
4. TestingScene typically index 0

## Performance Considerations

- Use occlusion culling for complex scenes
- Bake lighting when possible
- Optimize draw calls with batching
- Profile with Unity Profiler

## Creating New Scenes

1. File > New Scene
2. Choose template (3D default)
3. Set up lighting and camera
4. Save in Assets/Scenes/
5. Add to Build Settings
6. Document in this README
