using Microsoft.Xna.Framework;
using MonoGame.Extended.Tweening;
namespace GameJam.source
{
    public class BlackBarTrans
    {
        public static void TransIn()
        {
            BlackBar.blackBars.Add(new BlackBar("debugRect", new Vector2(0, -30), 30, 0, true));
            BlackBar.blackBars.Add(new BlackBar("debugRect", new Vector2(0, 240), 30, 0, false));
        }

        public static void TransOut()
        {
            foreach (BlackBar bb in BlackBar.blackBars)
            {
                if (bb.top)
                {
                    Globals.tweener.TweenTo(target: bb, expression: entity => entity.position, toValue: new Vector2(bb.position.X, bb.position.Y - 30), duration: .75f, delay: .5f)
                       .Easing(EasingFunctions.BounceOut);
                }
                else
                {
                    Globals.tweener.TweenTo(target: bb, expression: entity => entity.position, toValue: new Vector2(bb.position.X, bb.position.Y + 30), duration: .75f, delay: .5f)
                        .Easing(EasingFunctions.BounceOut);
                }
            }
        }

        public static void Update(GameTime gameTime)
        {
            foreach (BlackBar bb in BlackBar.blackBars)
                bb.Update(gameTime);
        }

        public static void Draw()
        {
            foreach (BlackBar bb in BlackBar.blackBars)
                bb.Draw();
        }
    }
}
