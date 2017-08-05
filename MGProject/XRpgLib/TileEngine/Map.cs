using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MGProject.XRpgLib.TileEngine
{
    public class Map
    {
        List<MapLayer> mapLayers = new List<MapLayer>();
        List<TileSet> tileSets = new List<TileSet>();

        // CONSTRUCTOR
        public Map(MapLayer mapLayer, TileSet tileSet)
        {
            this.mapLayers.Add(mapLayer);

            this.AddTileSet(tileSet);
        }

        // METHOD
        public void AddMapLayer(MapLayer mapLayer)
        {
            this.mapLayers.Add(mapLayer);
        }

        /// <summary>
        /// checks if tileset is present before adding to the list
        /// </summary>
        /// <param name="tileSet">the tileset to be added</param>
        public void AddTileSet(TileSet tileSet)
        {
            string tileSetName = tileSet.Image.Name;
            bool setAlreadyPresent = false;

            foreach (TileSet set in tileSets)
            {
                if (set.Image.Name == tileSetName)
                {
                    setAlreadyPresent = true;
                    break;
                }
            }

            if (!setAlreadyPresent)
                this.tileSets.Add(tileSet);
        }

        /// <summary>
        /// loops over all layers and draws them
        /// gets the proper tileset from the list
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle destination = new Rectangle(0, 0, Engine.TileWidth, Engine.TileHeight);
            foreach (MapLayer layer in mapLayers)
            {
                // Get proper tileset
                TileSet set = tileSets.Find(t => t.Image.Name == layer.tileSetName);

                // draw the blocks
                foreach (Tile tile in layer.layer)
                {
                    destination.X = tile.TileXIndex * 32;
                    destination.Y = tile.TileYIndex * 32;

                    spriteBatch.Draw(set.Image, destination, set.GetSpecificSourceRectangle(tile.TilesetIndex), Color.White);
                }
            }
        }
    }
}
