using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902_Sprint0
{
    class KeyboardController : IController
    {
        public Game1 Game { get; set; }

        public KeyboardController(Game1 game)
        {
            Game = game;
        }

        public void Update()
        {

            KeyboardState keyboardState = Keyboard.GetState();

            if(keyboardState.IsKeyDown(Keys.Q)) {
                Game.Exit();
            }
            else if(keyboardState.IsKeyDown(Keys.W))
            {
                // fixed, static
                Game.marioMoves = Game1.MarioMovement.Nowhere;
            }
            else if(keyboardState.IsKeyDown(Keys.E))
            {
                // fixed, animated
            }
            else if(keyboardState.IsKeyDown(Keys.R))
            {
                // vertical, static
                Game.marioMoves = Game1.MarioMovement.Up;
            }
            else if(keyboardState.IsKeyDown(Keys.T))
            {
                // horizontal, animated
                Game.marioMoves = Game1.MarioMovement.Right;
            }
        }
    }
}
