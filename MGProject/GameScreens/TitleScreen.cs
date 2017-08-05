using MGProject.XRpgLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MGProject.GameScreens
{
    public class TitleScreen : BaseGameState
    {
        Texture2D backgroundImage;

        public TitleScreen(Game game, GameStateManager manager)
        : base(game, manager)
        {
        }

        #region Method
        protected override void LoadContent()
        {
            ContentManager Content = GameRef.Content;
            backgroundImage = Content.Load<Texture2D>("titlescreen");
            base.LoadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            GameRef.spriteBatch.Begin();

            base.Draw(gameTime);

            GameRef.spriteBatch.Draw(
                backgroundImage,
                GameRef.screenRectangle,
                Color.White);

            //ControlManager.Draw(GameRef.SpriteBatch);

            GameRef.spriteBatch.End();
        }
        #endregion
    }
}
