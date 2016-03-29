using System;
using System.Collections.Generic;

[Serializable]
public class Save
{
    #region Public Fields

    public Dictionary<WorldPos, Block> blocks = new Dictionary<WorldPos, Block>();

    #endregion Public Fields

    #region Public Constructors

    public Save(Chunk chunk)
    {
        for (int x = 0; x < Chunk.chunkSize; x++)
        {
            for (int y = 0; y < Chunk.chunkSize; y++)
            {
                for (int z = 0; z < Chunk.chunkSize; z++)
                {
                    if (!chunk.blocks[x, y, z].changed)
                        continue;

                    WorldPos pos = new WorldPos(x, y, z);
                    blocks.Add(pos, chunk.blocks[x, y, z]);
                }
            }
        }
    }

    #endregion Public Constructors
}