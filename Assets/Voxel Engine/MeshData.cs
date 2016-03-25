using System.Collections.Generic;
using UnityEngine;

public class MeshData
{
    #region Public Fields

    public List<int> colTriangles = new List<int>();
    public List<Vector3> colVertices = new List<Vector3>();
    public List<int> triangles = new List<int>();
    public List<Vector2> uv = new List<Vector2>();
    public List<Vector3> vertices = new List<Vector3>();

    #endregion Public Fields

    #region Public Constructors

    public MeshData()
    {
    }

    #endregion Public Constructors

    #region Internal Methods

    internal void AddQuadTriangles()
    {
        triangles.Add(vertices.Count - 4);
        triangles.Add(vertices.Count - 3);
        triangles.Add(vertices.Count - 2);

        triangles.Add(vertices.Count - 4);
        triangles.Add(vertices.Count - 2);
        triangles.Add(vertices.Count - 1);
    }

    #endregion Internal Methods
}