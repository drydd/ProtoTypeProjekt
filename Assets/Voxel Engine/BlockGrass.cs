public class BlockGrass : Block
{
    #region Public Constructors

    public BlockGrass()
          : base()
    {
    }

    #endregion Public Constructors

    #region Public Methods

    public override Tile TexturePosition(Direction direction)
    {
        Tile tile = new Tile();

        switch (direction)
        {
            case Direction.up:
                tile.x = 2;
                tile.y = 0;
                return tile;

            case Direction.down:
                tile.x = 1;
                tile.y = 0;
                return tile;
        }

        tile.x = 3;
        tile.y = 0;

        return tile;
    }

    #endregion Public Methods
}