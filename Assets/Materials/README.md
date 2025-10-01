# Materials

This directory contains Unity materials and shaders for the project.

## Material Types

### Standard Materials
- Used for most 3D objects
- PBR (Physically Based Rendering)
- Configure: Albedo, Metallic, Smoothness, Normal Map

### Water Materials
- Ocean surface shaders
- Reflections and refractions
- Wave animations
- Foam and depth effects

### Terrain Materials
- Ground textures
- Blend multiple textures
- Height-based coloring
- Detail maps

### Sky Materials
- Skybox materials
- Procedural sky shaders
- Day/night cycle support

## Creating New Materials

1. Right-click in this folder
2. Create > Material
3. Name descriptively (e.g., `Mat_OceanWater`)
4. Assign shader (Standard, Custom, etc.)
5. Configure properties
6. Apply to MeshRenderer

## Material Organization

- Prefix with `Mat_` for easy identification
- Group related materials in subfolders
- Document custom shader parameters
- Use shared materials when possible

## Shader Properties

### Standard Shader
- **Albedo**: Base color/texture
- **Metallic**: Metal surface simulation
- **Smoothness**: Surface glossiness
- **Normal Map**: Surface detail
- **Emission**: Self-illumination

### Custom Shaders
Document custom shader properties here as they are created.
