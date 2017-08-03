using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MGProject.Test
{
    public class TileSet
    {
        Texture2D image;

        int tilesWide;
        int tilesHigh;
        int tileWidthInPixels;
        int tileHeightInPixels;

        Rectangle[] sourceRectangles;
        
        public Texture2D Image { get => image; set => image = value; }
        public int TilesWide { get => tilesWide; set => tilesWide = value; }
        public int TilesHigh { get => tilesHigh; set => tilesHigh = value; }
        public int TileWidthInPixels { get => tileWidthInPixels; set => tileWidthInPixels = value; }
        public int TileHeightInPixels { get => tileHeightInPixels; set => tileHeightInPixels = value; }
        public Rectangle[] SourceRectangles { get => (Rectangle[])sourceRectangles.Clone(); set => sourceRectangles = value; }

        // CONSTRUCTOR
        public TileSet(Texture2D image, int tilesWide, int tilesHigh, int tileWidthInPixels, int tileHeightInPixels) {
            Image = image;
            TilesWide = tilesWide;
            TilesHigh = tilesHigh;
            TileWidthInPixels = tileWidthInPixels;
            TileHeightInPixels = tileHeightInPixels;

            int tiles = tilesWide * tilesHigh;

            sourceRectangles = new Rectangle[tiles];

            int tile = 0;

            for (int y = 0; y < tilesHigh; y++)
            {
                for (int x = 0; x < tilesWide; x++)
                {
                    sourceRectangles[tile] = new Rectangle(x * tileWidthInPixels, y * tileHeightInPixels, tileWidthInPixels, tileHeightInPixels);
                    tile++;
                }
            }
        }

        // METHODS
        public Rectangle GetSpecificSourceRectangle(int index) {
            return this.sourceRectangles[index];
        }
    }
}
