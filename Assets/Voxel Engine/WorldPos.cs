using System;

[Serializable]
public struct WorldPos 
{
    #region Public Fields

    public int x, y, z;

    #endregion Public Fields

    #region Public Constructors

    public WorldPos(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    #endregion Public Constructors

    #region Public Methods

    public override bool Equals(object obj)
    {
        if (!(obj is WorldPos))
            return false;

        WorldPos pos = (WorldPos)obj;
        if (pos.x != x || pos.y != y || pos.z != z)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    #endregion Public Methods
}