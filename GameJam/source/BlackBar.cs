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
        public bool leaving = false;
        public static List<BlackBar> blackBars = new List<BlackBar>();
        public BlackBar(string path, Vector2 pos, int dim, float rot, bool _top) :base(path, pos, dim, rot)
        {
            top = _top;

            if (top)
            {
                 Globals.tweener.TweenTo(target: this, expression: entity => entity.position, toValue: new Vector2(position.X, position.Y + 30), duration: .75f, delay: .5f)
                    .Easing(EasingFunctions.BounceOut);
            }
            else
            {
                Globals.tweener.TweenTo(target: this, expression: entity => entity.position, toValue: new Vector2(position.X, position.Y - 30), duration: .75f, delay: .5f)
                    .Easing(EasingFunctions.BounceOut);
            }
        }


        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }

        public override void Draw()
        {
            Globals.spriteBatch.Draw(texture, new Rectangle((int)(position.X), (int)position.Y, (int)426, (int)scale), Color.White);
        }
    }
}
