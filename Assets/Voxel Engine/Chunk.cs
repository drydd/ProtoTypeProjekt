﻿using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]
public class Chunk : MonoBehaviour
{
    #region Public Fields

    public static int chunkSize = 16;
    public bool update = true;

    #endregion Public Fields

    #region Private Fields

    private Block[,,] blocks;

    private MeshCollider coll;

    private MeshFilter filter;

    #endregion Private Fields

    #region Public Methods

    public Block GetBlock(int x, int y, int z)
    {
        return blocks[x, y, z];
    }

    #endregion Public Methods

    #region Private Methods

    //Sends the calculated mesh information
    //to the mesh and collision components
    private void RenderMesh()
    {
    }

    private void RenderMesh(MeshData meshData)
    {
        filter.mesh.Clear();
        filter.mesh.vertices = meshData.vertices.ToArray();
        filter.mesh.triangles = meshData.triangles.ToArray();
    }

    // Use this for initialization
    private void Start()
    {
        filter = gameObject.GetComponent<MeshFilter>();
        coll = gameObject.GetComponent<MeshCollider>();

        blocks = new Block[chunkSize, chunkSize, chunkSize];

        for (int x = 0; x < chunkSize; x++)
        {
            for (int y = 0; y < chunkSize; y++)
            {
                for (int z = 0; z < chunkSize; z++)
                {
                    blocks[x, y, z] = new BlockAir();
                }
            }
        }

        blocks[3, 5, 2] = new Block();

        UpdateChunk();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    //Updates the Chunk based on its contents
    private void UpdateChunk()
    {
        MeshData meshData = new MeshData();

        for (int x = 0; x < chunkSize; x++)
        {
            for (int y = 0; y < chunkSize; y++)
            {
                for (int z = 0; z < chunkSize; z++)
                {
                    meshData = blocks[x, y, z].Blockdata(this, x, y, z, meshData);
                }
            }
        }

        RenderMesh(meshData);
    }

    #endregion Private Methods
}