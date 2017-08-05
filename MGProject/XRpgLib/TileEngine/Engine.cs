using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGProject.XRpgLib.TileEngine
{
    public class Engine
    {
        static int tileWidth;
        static int tileHeight;

        public static int TileWidth { get => tileWidth; set => tileWidth = value; }
        public static int TileHeight { get => tileHeight; set => tileHeight = value; }

        public Engine(int tileWidth, int tileHeight) {
            TileWidth = tileWidth;
            TileHeight = tileHeight;
        }
    }
}
