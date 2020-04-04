using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Engine
{
    class GameObject
    {
        protected Texture2D sprite;
        protected Vector2 velocity, position, origin;

        public GameObject(string this_sprite)
        {
            sprite = ExtendedGame.ContentManager.Load<Texture2D>(this_sprite);
            velocity = Vector2.Zero;
            position = Vector2.Zero;
            origin = new Vector2(Width, Height) / 2;
        }

        public virtual void Update(GameTime gameTime)
        {
            //position += velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, Color.White, 0, origin, 1f, SpriteEffects.None, 0);
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Width { get { return sprite.Width; } }

        public int Height { get { return sprite.Height; } }


        public Vector2 Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public Rectangle BoundingBox
        {
            get
            {
                // get the sprite's bounds
                Rectangle spriteBounds = sprite.Bounds;
                // add the object's position to it as an offset
                spriteBounds.Offset(position - origin);
                return spriteBounds;
            }
        }
    }
}

