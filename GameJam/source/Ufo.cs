using System;
using System.Collections.Generic;
using System.Text;
using MonoGame.Extended;
using MonoGame.Extended.Tweening;
using Microsoft.Xna.Framework;
using RPG;

namespace GameJam.source
{
    class Ufo : Entity
    {
        public static List<Ufo> ufos = new List<Ufo>();
        public SpriteAnimation anim;
        public int frames;
        public Ufo(string path, Vector2 position, int scale, float rotation, int _frames) : base(path, position, scale, rotation)
        {
            frames = _frames;
            anim = new SpriteAnimation(texture, frames, 9, 1f);
            body = new Rectangle((int)position.X, (int)position.Y, ((texture.Width /2) / frames) * scale, texture.Height);
            Globals.tweener.TweenTo(target: this, expression: entity => entity.position, toValue: new Vector2(position.X - 600, position.Y), duration: 4, delay: 1)
                .Easing(EasingFunctions.Linear);

        }

        public void MoveToEdge()
        {
            
            position.Y = Helpers.random.Next(20, 180);

            Globals.tweener.TweenTo(target: this, expression: entity => entity.position, toValue: new Vector2(position.X - 500, position.Y), duration: 4, delay: 1)
                .Easing(EasingFunctions.Linear);
        }

        public override void Update(GameTime gameTime)
        {
            body.X = (int)position.X;
            body.Y = (int)position.Y;
            anim.Position = position;
            anim.Update(gameTime);
            if (position.X < -29)
            {
                position.X = 460;
                MoveToEdge();
            }
            base.Update(gameTime);
        }

        public override void Draw()
        {
            //Globals.spriteBatch.Draw(pixel, body, Color.Red);
            anim.Draw(Globals.spriteBatch);
        }
    }
}
