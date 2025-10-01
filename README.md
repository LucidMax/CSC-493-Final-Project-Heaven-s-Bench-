# Heaven's Bench - CSC 493 Final Project

A Unity 3D interactive environment showcasing advanced game development techniques including NavMesh pathfinding, raycasting, collision detection, ragdoll physics, and procedural mesh generation.

## 🎮 Project Overview

Heaven's Bench is an immersive 3D simulation developed as a final project for CSC 493. The project demonstrates various Unity features and techniques for creating interactive environments with AI navigation, physics-based interactions, and custom-generated geometry.

## ✨ Features

### Core Systems
- **NavMesh AI Navigation**: Intelligent pathfinding system for autonomous agent movement
- **Raycasting System**: Object detection, selection, and environmental queries
- **Collision Detection**: Advanced physics with event-driven collision handling
- **Ragdoll Physics**: Realistic character physics with dynamic state transitions
- **Procedural Mesh Generation**: Runtime generation of terrain, primitives, and custom shapes

### Scenes
1. **TestingScene**: Core testing environment for prototyping and debugging features
2. **IslandScene**: Island environment with terrain, ocean, and atmospheric effects
3. **GameScene**: Main gameplay scene with all systems integrated

### Environment Features
- **Dynamic Terrain**: Procedurally generated landscapes using Perlin noise
- **Ocean System**: Water shader effects and environmental atmosphere
- **Lighting Tests**: Various lighting setups for day/night cycles and atmospheric effects
- **AI Navigation**: NavMesh-based pathfinding for NPC movement

## 🚀 Setup Instructions

### Prerequisites
- Unity Editor 2021.3.0f1 or later
- Git for version control
- Blender (optional, for custom asset creation)

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/LucidMax/CSC-493-Final-Project-Heaven-s-Bench-.git
   cd CSC-493-Final-Project-Heaven-s-Bench-
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Click "Open" or "Add"
   - Navigate to the cloned repository folder
   - Select the project folder
   - Unity will import all assets and configure the project

3. **Install Required Packages**
   - Unity Package Manager will automatically install dependencies
   - Required packages are listed in `Packages/manifest.json`
   - Key packages: AI Navigation, Unity Collaborate, TextMeshPro

### First Run

1. Open one of the scenes from `Assets/Scenes/`
2. Press Play button in Unity Editor to test the scene
3. Use keyboard/mouse controls to interact with the environment

## 📁 Project Structure

```
Heaven's Bench/
├── Assets/
│   ├── Scenes/           # Unity scene files
│   │   ├── TestingScene.unity
│   │   ├── IslandScene.unity
│   │   └── GameScene.unity
│   ├── Scripts/          # C# gameplay scripts
│   │   ├── NavMeshController.cs
│   │   ├── RaycastInteraction.cs
│   │   ├── CollisionDetector.cs
│   │   ├── RagdollPhysics.cs
│   │   └── ProceduralMeshGenerator.cs
│   ├── Materials/        # Unity materials and shaders
│   ├── Prefabs/          # Reusable game objects
│   └── Models/           # 3D models and Blender assets
├── ProjectSettings/      # Unity project configuration
├── Packages/             # Package dependencies
└── README.md
```

## 🎨 Blender Asset Integration

### Importing Blender Assets

1. **Export from Blender**
   - Export models as `.fbx` or `.blend` format
   - Ensure proper scale (Unity uses 1 unit = 1 meter)
   - Apply transforms before exporting

2. **Import to Unity**
   - Drag `.fbx` or `.blend` files into `Assets/Models/`
   - Unity will automatically convert and import
   - Configure import settings in Inspector

3. **Material Setup**
   - Reassign materials in Unity
   - Use Unity's Standard Shader or custom shaders
   - Configure textures and normal maps

### Recommended Blender Export Settings
- Scale: 1.0
- Forward: -Z Forward
- Up: Y Up
- Apply Modifiers: Yes
- Selected Objects: Yes

## 🔧 Unity Version Control

This project uses Unity Version Control (formerly Unity Collaborate) for team collaboration.

### Setting Up Version Control

1. **Enable Version Control**
   - Open Unity Editor
   - Go to Edit > Project Settings > Services
   - Link your Unity account
   - Enable Version Control

2. **Unity Collaborate (Cloud)**
   - Install Unity Collaborate package
   - Sign in with Unity account
   - Push/pull changes directly from Unity Editor

3. **Git Integration** (Alternative)
   - This repository uses Git for version control
   - `.gitignore` is configured for Unity projects
   - Commit scripts, scenes, and project settings
   - Avoid committing Library, Temp, and Build folders

### Best Practices
- Commit scene changes separately from script changes
- Use descriptive commit messages
- Pull before starting work
- Resolve merge conflicts in Unity's Scene Merge tool

## 🎯 Script Documentation

### NavMeshController.cs
Controls AI agent navigation using Unity's NavMesh system.
- `SetDestination(Vector3)`: Set target position
- `SetTarget(Transform)`: Follow a moving target
- `HasReachedDestination()`: Check if agent reached destination

### RaycastInteraction.cs
Handles raycasting for object interaction and detection.
- Mouse click detection and object selection
- Line of sight checks
- Debug visualization of rays

### CollisionDetector.cs
Advanced collision detection with Unity Events.
- Layer-based filtering
- Collision and trigger event callbacks
- Impact force tracking

### RagdollPhysics.cs
Manages ragdoll physics state transitions.
- `EnableRagdoll()`: Activate physics-based animation
- `DisableRagdoll()`: Return to animated state
- `ApplyForce(Vector3, Vector3)`: Apply forces to ragdoll

### ProceduralMeshGenerator.cs
Runtime mesh generation for terrain and primitives.
- Generate planes, terrain, cubes, and spheres
- Perlin noise terrain generation
- Custom UV mapping

## 🎮 Controls

- **Mouse**: Look around / Interact with objects
- **WASD**: Movement (if character controller present)
- **R**: Toggle ragdoll physics (testing)
- **Left Click**: Raycast interaction

## 🛠️ Development

### Adding New Features
1. Create new scripts in `Assets/Scripts/`
2. Follow existing naming conventions
3. Add XML documentation comments
4. Test in TestingScene before integrating

### Creating New Scenes
1. Duplicate an existing scene as template
2. Configure lighting and environment
3. Add NavMesh for AI navigation
4. Test all systems before committing

## 📝 Credits

**Project**: Heaven's Bench  
**Course**: CSC 493 - Game Development  
**Developer**: [Your Name]  
**Unity Version**: 2021.3.0f1  
**Assets**: Custom models created in Blender

## 📄 License

This project is created for educational purposes as part of CSC 493 coursework.

## 🐛 Known Issues

- NavMesh requires manual baking in each scene
- Some Blender materials may require manual reassignment
- Ragdoll physics may need tuning for specific character models

## 🔮 Future Enhancements

- [ ] Water physics and buoyancy system
- [ ] Advanced AI behaviors (patrol, chase, flee)
- [ ] Particle effects for environmental immersion
- [ ] Sound and music integration
- [ ] VR support for immersive exploration

## 📞 Support

For questions or issues, please open an issue on the GitHub repository or contact through the course communication channels.

---

**Last Updated**: 2024  
**Repository**: https://github.com/LucidMax/CSC-493-Final-Project-Heaven-s-Bench-
