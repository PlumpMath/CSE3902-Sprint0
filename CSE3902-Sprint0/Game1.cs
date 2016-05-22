using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections;

namespace CSE3902_Sprint0
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private ArrayList controllerList;

        public ISprite MarioSprite { get; set; }
        public const int MARIO_SPRITE_WIDTH = 85; // units: pixels
        public const int MARIO_SPRITE_HEIGHT = 108; 
        public enum MarioMovement { Up, Down, Left, Right, Nowhere };
        public MarioMovement marioMoves = MarioMovement.Nowhere;
        private Vector2 marioPos;

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
            controllerList = new ArrayList();
            controllerList.Add(new KeyboardController(this));
            controllerList.Add(new GamepadController(this));

            marioPos = new Vector2(400, 200);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D texture = Content.Load<Texture2D>("mario");
           // marioSprite = new AnimatedSprite(texture, 4, 4);
            MarioSprite = new StaticSprite(texture, new Rectangle(0, 0, MARIO_SPRITE_WIDTH, MARIO_SPRITE_HEIGHT));
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
            MarioSprite.Update();

            foreach(IController controller in controllerList)
            {
                controller.Update();
            }

            if(marioMoves == MarioMovement.Up)
            {
                if(marioPos.Y == 0)
                {
                    marioPos.Y = GraphicsDevice.Viewport.Height;
                }
                else
                {
                    marioPos.Y--;
                }
            }
            else if(marioMoves == MarioMovement.Nowhere)
            {

            }


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            MarioSprite.Draw(spriteBatch, marioPos);

            base.Draw(gameTime);
        }
    }
}
