using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MonoGame.Extended;
using RPG;

namespace GameJam.source
{
    class CrewGirl : Entity
    {
        SpriteAnimation anim;
        FlyingHero hero;
        public CrewGirl(string path, Vector2 position, int scale, float rot, FlyingHero _hero) : base(path, position, scale, rot)
        {
            hero = _hero;
            anim = new SpriteAnimation(texture, 1, 1, 0.5f);
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

            position.X = hero.position.X + 11;

        }

        public override void Draw()
        {
            anim.Draw(Globals.spriteBatch);
        }
    }
}
