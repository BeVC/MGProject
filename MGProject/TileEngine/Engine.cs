//using Microsoft.Xna.Framework;

//namespace MGProject.TileEngine
//{
//    public class Engine
//    {
//        #region Field 
//        static int tileWidth;
//        static int tileHeight;
//        #endregion

//        #region Properties
//        public static int TileWidth
//        {
//            get { return tileWidth; }
//        }

//        public static int TileHeight
//        {
//            get { return tileHeight; }
//        }
//        #endregion

//        #region Constructors

//        public Engine(int tileWidth, int tileHeight)
//        {
//            Engine.tileWidth = tileWidth;
//            Engine.tileHeight = tileHeight;
//        }

//        #endregion

//        #region Methods
//        // The VectorToCell method is used to get the position of a Vector2 in tiles on the map.
//        public static Point VectorToCell(Vector2 position)
//        {
//            return new Point((int)position.X / tileWidth, (int)position.Y / tileHeight);
//        }
//        #endregion
//    }
//}
