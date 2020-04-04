using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Engine
{
    class ExtendedGame : Game
    {
        protected GraphicsDeviceManager graphics;

        public static ContentManager ContentManager { get; private set; }

        public static int WindowWidth { get; private set; }
        public static int WindowHeight { get; private set; }

        protected ExtendedGame()
        {
            Content.RootDirectory = "Content";
            graphics = new GraphicsDeviceManager(this);

            WindowWidth = graphics.PreferredBackBufferWidth = 800;
            WindowHeight = graphics.PreferredBackBufferHeight = 500;

            ContentManager = Content;
        }

        protected override void LoadContent()
        {
            
        }
    }
}