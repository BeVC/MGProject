namespace MGProject.TileEngine
{
    public class MapLayer
    {
        #region Field
        Tile[,] map;
        #endregion

        #region Property
        public int Width
        {
            get { return map.GetLength(1); }
        }
        public int Height
        {
            get { return map.GetLength(0); }
        }
        #endregion

        #region Constructor
        public MapLayer(Tile[,] map)
        {
            this.map = (Tile[,])map.Clone();
        }
        public MapLayer(int width, int height)
        {
            map = new Tile[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    map[y, x] = new Tile(0, 0);
                }
            }
        }
        #endregion

        #region Method
        public Tile GetTile(int x, int y)
        {
            return map[x, y];
        }

        public void SetTile(int x, int y, Tile tile)
        {
            map[y, x] = tile;
        }

        public void SetTile(int x, int y, int tileIndex, int tileset)
        {
            map[y, x] = new Tile(tileIndex, tileset);
        }
        #endregion
    }
}
