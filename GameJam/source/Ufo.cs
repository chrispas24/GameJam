using System;
using System.Collections.Generic;
using System.Text;
using MonoGame.Extended;
using MonoGame.Extended.Tweening;
using Microsoft.Xna.Framework;
using RPG;
using System;

namespace GameJam.source
{
    class Ufo : Entity
    {
        public static List<Ufo> ufos = new List<Ufo>();
        public SpriteAnimation anim;
        public int num;
        public Ufo(string path, Vector2 position, int scale, float rotation, int numm) : base(path, position, scale, rotation)
        {

            anim = new SpriteAnimation(texture, 9, 9);
            body = new Rectangle((int)position.X, (int)position.Y, (texture.Width) * scale, texture.Height * scale);
            num = numm;
            MoveToEdge();


        }

        public void MoveToEdge()
        {
            
            position.Y = Helpers.random.Next(20, 180);

            Globals.tweener.TweenTo(target: this, expression: entity => entity.position, toValue: new Vector2(position.X - 500, position.Y), duration: 4, delay: 1)
                .Easing(EasingFunctions.Linear);
        }

        public override void Update(GameTime gameTime)
        {

            anim.Position = position;
            anim.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw()
        {
            
            anim.Draw(Globals.spriteBatch);
        }
    }
}
