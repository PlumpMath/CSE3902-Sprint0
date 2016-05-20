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

        }

        public void Update()
        {
        }
    }
}
