using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Collision
{
    public class BoxRight:Box
    {
        public BoxRight(Texture2D texture, Vector2 startPosition)
        :base(texture, startPosition)
        {
            color = Color.Black;
        }

        public override void Update(){
            position.X++;
            hitbox.Location = position.ToPoint();
        }
    }
}