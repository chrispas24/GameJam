using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using MonoGame.Extended.Tweening;
using MonoGame.Extended.Graphics;

namespace GameJam
{
    class Globals
    {
        public static ContentManager content;
        public static SpriteBatch spriteBatch;
        public static Tweener tweener = new Tweener();
    }
}
