//using MGProject.TileEngine;
using MGProject.Test;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MGProject
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // PLAYER
        Texture2D playerChar;
        Vector2 playerCharPos;
        Vector2 playerCharOrigin;

        // SHEETS
        Texture2D terrain1Sheet;

        // MAP
        Engine engine = new Engine(32, 32);
        TileSet tileset;
        MapLayer layer1;
        MapLayer layer2;
        Map map;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            IsMouseVisible = true;
            base.Initialize();
            // PUT CHAR CENTER MAP
            playerCharPos = new Vector2(graphics.GraphicsDevice.Viewport.Width / 2, graphics.GraphicsDevice.Viewport.Height / 2);
            playerCharOrigin = new Vector2(16, 16);

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            playerChar = this.Content.Load<Texture2D>("char");
            terrain1Sheet = this.Content.Load<Texture2D>("terrain1");
            tileset = new TileSet(terrain1Sheet, 2, 1, 32, 32);
            layer1 = new MapLayer(4, 4, 0, terrain1Sheet.Name);
            layer2 = new MapLayer(4, 4, 1, terrain1Sheet.Name, new Vector2(4,0));

            map = new Map(layer1, tileset);
            map.AddMapLayer(layer2);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (IsActive)
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                    Exit();

                // TODO: Add your update logic here

                // KEYBOARD STATE & MOVEMENT
                KeyboardState state = Keyboard.GetState();

                if (state.IsKeyDown(Keys.Right))
                {
                    playerCharPos.X += 10;
                }
                if (state.IsKeyDown(Keys.Left))
                {
                    playerCharPos.X -= 10;
                }
                if (state.IsKeyDown(Keys.Up))
                {
                    playerCharPos.Y -= 10;
                }
                if (state.IsKeyDown(Keys.Down))
                {
                    playerCharPos.Y += 10;
                }

                base.Update(gameTime);
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            map.Draw(spriteBatch);
            spriteBatch.Draw(playerChar, playerCharPos, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
