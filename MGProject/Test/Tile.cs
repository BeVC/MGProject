namespace MGProject.Test
{
    public class Tile
    {
        int tileXIndex;
        int tileYIndex;
        int tilesetIndex;

        public int TilesetIndex { get => tilesetIndex; set => tilesetIndex = value; }
        public int TileXIndex { get => tileXIndex; set => tileXIndex = value; }
        public int TileYIndex { get => tileYIndex; set => tileYIndex = value; }

        public Tile(int tilesetIndex, int tileXIndex, int tileYIndex) {
            TilesetIndex = tilesetIndex;
            TileXIndex = tileXIndex;
            TileYIndex = tileYIndex;
        }
    }
}
