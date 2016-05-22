using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902_Sprint0
{
    class GamepadController : IController
    {
        public Game1 Game { get; set; }

        public GamepadController(Game1 game)
        {
            Game = game;
        }

        public void Update()
        {
            GamePadState gamePadState = GamePad.GetState(PlayerIndex.One);

            if(gamePadState.IsButtonDown(Buttons.Start))
            {
                Game.Exit();
            }
            else if(gamePadState.IsButtonDown(Buttons.A))
            {
                // fixed, static
                Game.marioMoves = Game1.MarioMovement.Nowhere;
            }
            else if(gamePadState.IsButtonDown(Buttons.B))
            {
                // fixed, animated
            }
            else if(gamePadState.IsButtonDown(Buttons.X))
            {
                // vertical, static
                Game.marioMoves = Game1.MarioMovement.Up;
            }
            else if(gamePadState.IsButtonDown(Buttons.Y))
            {
                // horizontal, animated
                Game.marioMoves = Game1.MarioMovement.Right;
            }
        }
    }
}
