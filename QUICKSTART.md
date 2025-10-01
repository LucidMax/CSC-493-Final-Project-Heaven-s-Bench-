# Quick Start Guide - Heaven's Bench

Get up and running with Heaven's Bench in 5 minutes!

## 🚀 Installation (5 minutes)

### Step 1: Install Unity Hub (2 minutes)
1. Download [Unity Hub](https://unity.com/download)
2. Install Unity Hub
3. Create/Sign in to Unity account

### Step 2: Install Unity Editor (2 minutes)
1. Open Unity Hub
2. Go to "Installs" tab
3. Click "Install Editor"
4. Select Unity **2021.3.0f1** (LTS)
5. Add modules (optional):
   - Visual Studio / VS Code
   - Documentation
   - Platform build support (if needed)

### Step 3: Clone and Open Project (1 minute)
```bash
# Clone repository
git clone https://github.com/LucidMax/CSC-493-Final-Project-Heaven-s-Bench-.git

# Navigate to project
cd CSC-493-Final-Project-Heaven-s-Bench-
```

Open in Unity Hub:
1. Click "Open" or "Add"
2. Select the project folder
3. Unity will import packages (wait 1-2 minutes)

## 🎮 First Run

### Open a Scene
1. In Project panel: `Assets/Scenes/`
2. Double-click `TestingScene.unity`
3. Scene opens in Scene View

### Play the Scene
1. Click **Play** button (▶️) at top
2. Game View activates
3. Test interactions
4. Click **Play** again to stop

### Try the Features

#### Test Raycasting
1. Scene should have RaycastInteraction script active
2. Click **Play**
3. Click objects in scene
4. Check Console for raycast hits

#### Test NavMesh (if configured)
1. Objects with NavMeshController will navigate
2. Set target destinations
3. Agents move automatically

#### Test Ragdoll Physics
1. Objects with RagdollPhysics
2. Press **R** key to toggle ragdoll
3. Physics takes over

#### Test Procedural Mesh
1. Objects with ProceduralMeshGenerator
2. Mesh generates at start
3. Change settings in Inspector
4. Click "Generate Mesh" button

## 📝 Common First Tasks

### Create Your First Script
```csharp
// Assets/Scripts/MyFirstScript.cs
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello from Heaven's Bench!");
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed!");
        }
    }
}
```

### Add Script to GameObject
1. Create Empty GameObject (Right-click Hierarchy)
2. Select GameObject
3. In Inspector, click "Add Component"
4. Type script name
5. Select your script

### Create Your First Object
1. Hierarchy > Right-click
2. 3D Object > Cube
3. Position in Scene View
4. Add Material from Materials folder
5. Add scripts for behavior

### Set Up NavMesh
1. Create terrain/floor (plane)
2. Mark as "Navigation Static"
3. Window > AI > Navigation
4. Click "Bake"
5. Add NavMeshAgent to character
6. Add NavMeshController script

## 🎯 Explore the Scenes

### TestingScene
**Purpose**: Quick testing and prototyping
- Open: `Assets/Scenes/TestingScene.unity`
- Use for: New script testing
- Clean slate for experimentation

### IslandScene
**Purpose**: Island environment showcase
- Open: `Assets/Scenes/IslandScene.unity`
- Features: Fog, atmospheric lighting
- Use for: Terrain and navigation

### GameScene
**Purpose**: Main gameplay integration
- Open: `Assets/Scenes/GameScene.unity`
- Features: All systems integrated
- Use for: Final testing

## 🛠️ Unity Editor Basics

### Essential Windows
- **Scene View** (Ctrl+1): Edit scene
- **Game View** (Ctrl+2): Play test
- **Inspector** (Ctrl+3): Edit properties
- **Hierarchy** (Ctrl+4): Scene objects
- **Project** (Ctrl+5): Files and assets
- **Console** (Ctrl+Shift+C): Logs and errors

### Navigation
- **Scene Pan**: Middle mouse drag
- **Scene Rotate**: Alt + Left mouse drag
- **Scene Zoom**: Scroll wheel
- **Frame Object**: F key (with object selected)

### Shortcuts
- **Play/Stop**: Ctrl+P
- **Pause**: Ctrl+Shift+P
- **Step Frame**: Ctrl+Alt+P
- **Save Scene**: Ctrl+S
- **New GameObject**: Ctrl+Shift+N

## 📚 Learn More

### Documentation
- [Main README](README.md) - Full documentation
- [Contributing Guide](CONTRIBUTING.md) - Development workflow
- [Scripts Docs](Assets/Scripts/README.md) - Script API
- [Scenes Docs](Assets/Scenes/README.md) - Scene information

### Unity Resources
- [Unity Learn](https://learn.unity.com/) - Free tutorials
- [Unity Manual](https://docs.unity3d.com/Manual/) - Complete reference
- [Unity Scripting API](https://docs.unity3d.com/ScriptReference/) - Code reference

## ❓ Troubleshooting

### Project Won't Open
- Check Unity version matches (2021.3.0f1)
- Delete `Library` folder and reopen
- Verify all files downloaded correctly

### Scripts Have Errors
- Check Console for error messages
- Verify using statements at top
- Check for syntax errors (missing semicolons)
- Reimport script (right-click > Reimport)

### Objects Don't Appear
- Check object is in scene (Hierarchy)
- Verify position is visible to camera
- Check layer/culling settings
- Ensure renderer is enabled

### Performance Issues
- Lower Quality settings (Edit > Project Settings > Quality)
- Reduce screen resolution
- Close other applications
- Profile with Unity Profiler (Window > Analysis > Profiler)

## 🎓 Next Steps

1. **Explore Scripts** - Open and read existing scripts
2. **Modify Parameters** - Change values in Inspector
3. **Create Content** - Add your own objects and behaviors
4. **Test Features** - Try all the demo systems
5. **Build Something** - Create your own scene
6. **Read Docs** - Study the detailed documentation

## 💡 Tips for Success

- Save frequently (Ctrl+S)
- Test in Play mode often
- Read Console messages
- Use version control (Git)
- Comment your code
- Ask for help when stuck

---

**Ready to Build?** Open Unity, load a scene, and start creating!

For detailed information, see the [Main README](README.md)
