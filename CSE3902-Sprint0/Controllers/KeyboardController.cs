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
        public ISprite MarioSprite { get; set; }

        public KeyboardController(Game1 game )
        {
            Game = game;
        }

        public void Update()
        {
            if(Keyboard.GetState().IsKeyDown(Keys.Q)) {
                Game.Exit();
            }
        }
    }
}
