namespace MGProject.Test
{
    public class MapLayer
    {
        public Tile[,] layer;
        public string tileSetName;

        //public Tile[,] Layer { get => layer; set => layer = value; }

        public MapLayer(int width, int height, int tilesetIndex, string tileSetName) {
            layer = new Tile[width, height];
            this.tileSetName = tileSetName;
            Tile tile;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    tile = new Tile(tilesetIndex, x, y);
                    layer[x, y] = tile;
                }
            }
        }
    }
}
