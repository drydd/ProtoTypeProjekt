public class BlockAir : Block
{
    #region Public Constructors

    public BlockAir() : base()
    {
    }

    #endregion Public Constructors

    #region Public Methods

    public override MeshData Blockdata(Chunk chunk, int x, int y, int z, MeshData meshData)
    {
        return meshData;
    }

    public override bool IsSolid(Direction direction)
    {
        return false;
    }

    #endregion Public Methods
}