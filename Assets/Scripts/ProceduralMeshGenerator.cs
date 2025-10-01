using UnityEngine;

/// <summary>
/// Procedural mesh generation for creating custom geometry at runtime
/// Supports terrain, primitives, and custom shapes
/// </summary>
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ProceduralMeshGenerator : MonoBehaviour
{
    [Header("Mesh Settings")]
    [SerializeField] private MeshType meshType = MeshType.Plane;
    [SerializeField] private int gridSize = 10;
    [SerializeField] private float cellSize = 1f;
    [SerializeField] private bool generateOnStart = true;
    
    [Header("Terrain Settings")]
    [SerializeField] private float terrainHeight = 2f;
    [SerializeField] private float noiseScale = 0.3f;
    [SerializeField] private int noiseSeed = 0;
    
    private MeshFilter meshFilter;
    private Mesh mesh;
    
    public enum MeshType
    {
        Plane,
        Terrain,
        Cube,
        Sphere
    }
    
    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        
        if (generateOnStart)
        {
            GenerateMesh();
        }
    }
    
    public void GenerateMesh()
    {
        mesh = new Mesh();
        mesh.name = "Procedural Mesh";
        
        switch (meshType)
        {
            case MeshType.Plane:
                GeneratePlane();
                break;
            case MeshType.Terrain:
                GenerateTerrain();
                break;
            case MeshType.Cube:
                GenerateCube();
                break;
            case MeshType.Sphere:
                GenerateSphere();
                break;
        }
        
        meshFilter.mesh = mesh;
        Debug.Log($"Generated {meshType} mesh with {mesh.vertexCount} vertices");
    }
    
    void GeneratePlane()
    {
        Vector3[] vertices = new Vector3[(gridSize + 1) * (gridSize + 1)];
        Vector2[] uvs = new Vector2[vertices.Length];
        int[] triangles = new int[gridSize * gridSize * 6];
        
        // Generate vertices
        for (int z = 0, i = 0; z <= gridSize; z++)
        {
            for (int x = 0; x <= gridSize; x++, i++)
            {
                vertices[i] = new Vector3(x * cellSize, 0, z * cellSize);
                uvs[i] = new Vector2((float)x / gridSize, (float)z / gridSize);
            }
        }
        
        // Generate triangles
        for (int z = 0, ti = 0, vi = 0; z < gridSize; z++, vi++)
        {
            for (int x = 0; x < gridSize; x++, ti += 6, vi++)
            {
                triangles[ti] = vi;
                triangles[ti + 1] = vi + gridSize + 1;
                triangles[ti + 2] = vi + 1;
                triangles[ti + 3] = vi + 1;
                triangles[ti + 4] = vi + gridSize + 1;
                triangles[ti + 5] = vi + gridSize + 2;
            }
        }
        
        mesh.vertices = vertices;
        mesh.uv = uvs;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
    
    void GenerateTerrain()
    {
        Vector3[] vertices = new Vector3[(gridSize + 1) * (gridSize + 1)];
        Vector2[] uvs = new Vector2[vertices.Length];
        int[] triangles = new int[gridSize * gridSize * 6];
        
        // Generate vertices with Perlin noise for terrain
        for (int z = 0, i = 0; z <= gridSize; z++)
        {
            for (int x = 0; x <= gridSize; x++, i++)
            {
                float height = Mathf.PerlinNoise(
                    (x + noiseSeed) * noiseScale, 
                    (z + noiseSeed) * noiseScale
                ) * terrainHeight;
                
                vertices[i] = new Vector3(x * cellSize, height, z * cellSize);
                uvs[i] = new Vector2((float)x / gridSize, (float)z / gridSize);
            }
        }
        
        // Generate triangles
        for (int z = 0, ti = 0, vi = 0; z < gridSize; z++, vi++)
        {
            for (int x = 0; x < gridSize; x++, ti += 6, vi++)
            {
                triangles[ti] = vi;
                triangles[ti + 1] = vi + gridSize + 1;
                triangles[ti + 2] = vi + 1;
                triangles[ti + 3] = vi + 1;
                triangles[ti + 4] = vi + gridSize + 1;
                triangles[ti + 5] = vi + gridSize + 2;
            }
        }
        
        mesh.vertices = vertices;
        mesh.uv = uvs;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
    
    void GenerateCube()
    {
        Vector3[] vertices = {
            // Front face
            new Vector3(-0.5f, -0.5f, 0.5f), new Vector3(0.5f, -0.5f, 0.5f),
            new Vector3(0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, 0.5f),
            // Back face
            new Vector3(0.5f, -0.5f, -0.5f), new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, -0.5f),
            // Top face
            new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(0.5f, 0.5f, 0.5f),
            new Vector3(0.5f, 0.5f, -0.5f), new Vector3(-0.5f, 0.5f, -0.5f),
            // Bottom face
            new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f),
            new Vector3(0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f),
            // Right face
            new Vector3(0.5f, -0.5f, 0.5f), new Vector3(0.5f, -0.5f, -0.5f),
            new Vector3(0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, 0.5f),
            // Left face
            new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(-0.5f, -0.5f, 0.5f),
            new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, -0.5f)
        };
        
        int[] triangles = {
            0, 2, 1, 0, 3, 2,       // Front
            4, 6, 5, 4, 7, 6,       // Back
            8, 10, 9, 8, 11, 10,    // Top
            12, 14, 13, 12, 15, 14, // Bottom
            16, 18, 17, 16, 19, 18, // Right
            20, 22, 21, 20, 23, 22  // Left
        };
        
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
    
    void GenerateSphere()
    {
        // Simple sphere using icosphere subdivision
        int subdivisions = 2;
        float radius = 0.5f;
        
        // Create icosahedron
        float t = (1f + Mathf.Sqrt(5f)) / 2f;
        
        Vector3[] vertices = {
            new Vector3(-1, t, 0).normalized * radius,
            new Vector3(1, t, 0).normalized * radius,
            new Vector3(-1, -t, 0).normalized * radius,
            new Vector3(1, -t, 0).normalized * radius,
            new Vector3(0, -1, t).normalized * radius,
            new Vector3(0, 1, t).normalized * radius,
            new Vector3(0, -1, -t).normalized * radius,
            new Vector3(0, 1, -t).normalized * radius,
            new Vector3(t, 0, -1).normalized * radius,
            new Vector3(t, 0, 1).normalized * radius,
            new Vector3(-t, 0, -1).normalized * radius,
            new Vector3(-t, 0, 1).normalized * radius
        };
        
        int[] triangles = {
            0, 11, 5, 0, 5, 1, 0, 1, 7, 0, 7, 10, 0, 10, 11,
            1, 5, 9, 5, 11, 4, 11, 10, 2, 10, 7, 6, 7, 1, 8,
            3, 9, 4, 3, 4, 2, 3, 2, 6, 3, 6, 8, 3, 8, 9,
            4, 9, 5, 2, 4, 11, 6, 2, 10, 8, 6, 7, 9, 8, 1
        };
        
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
    
    public void UpdateMeshType(MeshType newType)
    {
        meshType = newType;
        GenerateMesh();
    }
}
