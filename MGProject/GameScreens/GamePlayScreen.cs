using MGProject.XRpgLib;
using MGProject.XRpgLib.TileEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGProject.GameScreens
{
    public class GamePlayScreen: BaseGameState
    {
        #region Field Region
        // SHEETS
        Texture2D terrain1Sheet;

        // MAP
        Engine engine = new Engine(32, 32);
        TileSet tileset;
        MapLayer layer1;
        MapLayer layer2;
        Map map;

        #endregion
        #region Property Region
        #endregion
        #region Constructor Region
        public GamePlayScreen(Game game, GameStateManager manager)
        : base(game, manager)
        {
        }
        #endregion
        #region XNA Method Region
        public override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            terrain1Sheet = Game.Content.Load<Texture2D>("terrain1");
            tileset = new TileSet(terrain1Sheet, 2, 1, 32, 32);

            layer1 = new MapLayer(20, 20, 0, terrain1Sheet.Name);
            layer2 = new MapLayer(20, 20, 1, terrain1Sheet.Name, new Vector2(20, 0));

            map = new Map(layer1, tileset);
            map.AddMapLayer(layer2);

            base.LoadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            GameRef.spriteBatch.Begin();
            map.Draw(GameRef.spriteBatch);
            //spriteBatch.Draw(playerChar, playerCharPos, Color.White);

            GameRef.spriteBatch.End();

            base.Draw(gameTime);
        }

        #endregion
        #region Abstract Method Region
        #endregion

    }
}
