using System;
using System.Collections.Generic;
using System.Text;
using MonoGame.Extended;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using RPG;
using Apos.Input;
using Track = Apos.Input.Track;

namespace GameJam.source
{
    class FlyingHero : Entity
    {
        private Color ropeColor = new Color(138, 80, 65, 255);
        public SpriteAnimation anim;
        private float ropeX;
        public FlyingHero(string path, Vector2 position, int scale, float rotation, int frames) : base(path, position, scale, rotation)
        {
            anim = new SpriteAnimation(texture, frames, 12, 1f);
            body = new Rectangle((int)position.X, (int)position.Y, ((texture.Width / 2) / frames) * scale, texture.Height);
        }

        public float RopeX
        {
            get { return ropeX; }
            set { ropeX = value; }
        }

        public override void Update(GameTime gameTime)
        {
            #region Animation
            body.X = (int)position.X;
            body.Y = (int)position.Y;
            anim.Position = position;
            anim.Update(gameTime);
            #endregion

            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (position.Y < 190)
            {
                if (KeyboardCondition.Held(Keys.S)) position.Y += (100 * dt);
            }
            if (position.Y > 30)
            {
                if (KeyboardCondition.Held(Keys.W)) position.Y -= (100 * dt);
            }
            if (position.X > 0)
            {
                if (KeyboardCondition.Held(Keys.D)) position.X += (100 * dt);
            }
            if (position.X < 400)
                if (KeyboardCondition.Held(Keys.A)) position.X -= (100 * dt);
            
        }

        public override void Draw()
        {
            
            anim.Draw(Globals.spriteBatch);
            Globals.spriteBatch.DrawLine(body.X + 18, body.Y + 14, ropeX, 30, ropeColor, 1);
        }
    }
}
