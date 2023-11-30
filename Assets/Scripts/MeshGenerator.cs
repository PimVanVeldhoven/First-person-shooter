using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(MeshRenderer))]

public class MeshGenerator : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();

        GetComponent<MeshCollider>().sharedMesh = mesh;
        GetComponent<MeshCollider>().convex = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateShape()
    {
        vertices = new Vector3[]
        {
            new Vector3 (0f, 0f, 0f),//0
            new Vector3 (1f, 0f, 0f),//1
            new Vector3 (0f,0f, 1f),//2
            new Vector3 (1f, 0f, 1f),//3
            new Vector3 (0.5f,1f,0.5f),//4
            new Vector3 (0.5F,-1F,0.5F),//5
        };
        triangles = new int[]
        {
            0,1,2,
            3,2,1,
            0,4,1,
            1,4,3,
            3,4,2,
            2,4,0,
            1,5,0,
            0,5,2,
            2,5,3,
            3,5,1,
        };
    }
    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}
