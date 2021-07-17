using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
namespace GameJam
{
    class Helpers
    {
        public static bool CollisionCheck(Rectangle rec1, Rectangle rec2)
        {
            if (rec1.X < rec2.X + rec2.Width
                && rec1.X + rec1.Width > rec2.X
                && rec1.Y < rec2.Y + rec2.Height
                && rec1.Y + rec1.Height > rec2.Y)
            {
                return true;
            }
            return false;
        }
    }
}
