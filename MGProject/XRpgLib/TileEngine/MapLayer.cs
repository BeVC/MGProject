using Microsoft.Xna.Framework;

namespace MGProject.XRpgLib.TileEngine
{
    public class MapLayer
    {
        public Tile[,] layer;
        public string tileSetName;

        public int Width
        {
            get { return layer.GetLength(0); }
        }
        public int Height
        {
            get { return layer.GetLength(1); }
        }

        //public Tile[,] Layer { get => layer; set => layer = value; }

        public MapLayer(int width, int height, int tilesetIndex, string tileSetName)
        {
            layer = new Tile[width, height];
            this.tileSetName = tileSetName;
            Tile tile;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int testX = x;
                    int testY = y;

                    tile = new Tile(tilesetIndex, testX, testY);
                    layer[x, y] = tile;
                }
            }
        }

        public MapLayer(int width, int height, int tilesetIndex, string tileSetName, Vector2 appendCoords)
        {
            layer = new Tile[width, height];
            this.tileSetName = tileSetName;
            Tile tile;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int testX = x + (int)appendCoords.X;
                    int testY = y + (int)appendCoords.Y;

                    tile = new Tile(tilesetIndex, testX, testY);
                    layer[x, y] = tile;
                }
            }
        }
    }
}
