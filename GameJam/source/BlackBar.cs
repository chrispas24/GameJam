using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Apos.Input;
using Track = Apos.Input.Track;
using MonoGame.Extended.Tweening;
namespace GameJam.source
{
    class BlackBar : Sprite
    {
        public bool top = true;
        public static List<BlackBar> blackBars = new List<BlackBar>();

        public BlackBar(string path, Vector2 pos, int dim, float rot, bool _top) :base(path, pos, dim, rot)
        {
            top = _top;
            if (top)
            {
                 Globals.tweener.TweenTo(target: this, expression: entity => entity.position, toValue: new Vector2(position.X, position.Y + 30), duration: 2f, delay: 0)
                    .Easing(EasingFunctions.CubicOut);
            }
            else
            {
                Globals.tweener.TweenTo(target: this, expression: entity => entity.position, toValue: new Vector2(position.X, position.Y - 30), duration: 2f, delay: 0)
                    .Easing(EasingFunctions.CubicOut);
            }
        }

        public override void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            base.Update(gameTime);
            Globals.tweener.Update(dt);
        }

        public override void Draw()
        {
            Globals.spriteBatch.Draw(texture, new Rectangle((int)(position.X), (int)position.Y, (int)426, (int)scale), Color.White);
        }
    }
}
