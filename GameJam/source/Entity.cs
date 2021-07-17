using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Apos.Input;
using Track = Apos.Input.Track;
using MonoGame.Extended.Tweening;
using MonoGame.Extended.Graphics;


namespace GameJam.source
{
    class Entity : Sprite
    {
        public static List<Entity> entities = new List<Entity>();
        public Vector2 physPosition;
        public Entity(string path, Vector2 position, int _dim, float rot) : base(path, position, _dim, rot)
        {
            physPosition = new Vector2(position.X / 2, position.Y / 1.5f);
        }

        public override void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (KeyboardCondition.Pressed(Keys.Space))
            {
                Globals.tweener.TweenTo(target: this, expression: entity => entity.position, toValue: new Vector2(position.X, position.Y + 200), duration: 1f, delay: 0)
                    .Easing(EasingFunctions.BounceOut);

            }
            
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}
