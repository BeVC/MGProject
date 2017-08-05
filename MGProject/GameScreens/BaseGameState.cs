using MGProject.XRpgLib;
using Microsoft.Xna.Framework;

namespace MGProject.GameScreens
{
    public class BaseGameState: GameState
    {
        protected Game1 GameRef;

        public BaseGameState(Game game, GameStateManager manager): base(game, manager)
        {
            GameRef = (Game1)game;
        }
    }
}
