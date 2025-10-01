# 3D Models

This directory contains 3D models for the Heaven's Bench project.

## Model Sources

### Blender Assets
Custom models created in Blender for this project:
- Characters
- Environment pieces
- Props and objects
- Optimized for Unity

### Unity Primitives
Basic shapes used for prototyping:
- Cubes, Spheres, Capsules
- Planes and Quads
- Cylinders

### Asset Store
Third-party models from Unity Asset Store:
- Terrain assets
- Vegetation packs
- Character models
- Check licenses before use

## Blender to Unity Workflow

### Export from Blender
1. File > Export > FBX (.fbx)
2. Settings:
   - Scale: 1.0
   - Forward: -Z Forward
   - Up: Y Up
   - Apply Modifiers: Yes
   - Smoothing: Face
3. Save to this directory

### Import Settings in Unity
1. Select model in Project
2. Inspector > Model tab
3. Configure:
   - Scale Factor: 1
   - Mesh Compression: Medium
   - Read/Write: Off (for performance)
   - Optimize Mesh: On
   - Generate Colliders: As needed

### Materials
1. Extract materials
2. Right-click model
3. Extract Materials
4. Move to Materials folder
5. Reassign textures

## Model Organization

### Naming Convention
- `Char_` - Characters
- `Env_` - Environment
- `Prop_` - Props and objects
- `Veg_` - Vegetation

Example: `Char_HumanMale01.fbx`

### Folder Structure
```
Models/
├── Characters/
│   ├── Human/
│   └── NPC/
├── Environment/
│   ├── Buildings/
│   ├── Terrain/
│   └── Nature/
└── Props/
    ├── Interactive/
    └── Static/
```

## Optimization Guidelines

### Polygon Count
- Background objects: 500-2000 tris
- Mid-ground objects: 2000-5000 tris
- Characters: 5000-10000 tris
- LOD (Level of Detail) for distant objects

### Textures
- Power of 2 dimensions (512, 1024, 2048)
- Compress textures appropriately
- Use atlases when possible
- Reasonable resolution (2K max)

### Best Practices
- Clean topology (quads preferred)
- Apply transformations before export
- Merge duplicate vertices
- Remove unnecessary geometry
- Use instancing for repeated objects

## Model Formats

### Supported Formats
- **.fbx** - Recommended, most compatible
- **.blend** - Direct Blender files
- **.obj** - Basic geometry only
- **.dae** - Collada format

### Recommended: FBX
- Supports animations
- Maintains hierarchy
- Industry standard
- Good compression

## Rigging and Animation

### Character Rigging
1. Create armature in Blender
2. Weight paint for smooth deformation
3. Export with armature
4. Configure in Unity Animator

### Animation Import
1. Import animated FBX
2. Inspector > Animation tab
3. Create Animation Clips
4. Set up Animator Controller
5. Use with RagdollPhysics script

## Blender Tips for Unity

### Before Export
- Apply all transforms (Ctrl+A)
- Remove doubles/merge vertices
- Check normals (face orientation)
- Center pivot point
- Name objects clearly

### UV Mapping
- Unwrap models properly
- Avoid overlapping UVs
- Stay within 0-1 bounds
- Use seams strategically

### Materials
- Use principled BSDF
- Name materials descriptively
- Keep material count low
- Bake complex materials

## Common Issues

### Model appears wrong scale
- Check Scale Factor in import settings
- Apply scale in Blender before export
- Use consistent units (meters)

### Missing materials
- Extract materials from model
- Reassign textures manually
- Check texture paths

### Animations not working
- Verify Animation Type (Humanoid/Generic)
- Check armature export
- Configure Avatar properly

## Resources

- [Unity FBX Export Guide](https://docs.unity3d.com/Manual/FBXSDK.html)
- [Blender to Unity Tips](https://docs.unity3d.com/Manual/BlenderAndUnity.html)
- [Character Import Workflow](https://docs.unity3d.com/Manual/CharacterImport.html)
