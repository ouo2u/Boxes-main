using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Collision
{
    public abstract class Box
    {
        protected Texture2D texture;
        protected Vector2 position;
        protected Rectangle hitbox;
        protected Color color;

        public Rectangle Hitbox{
            get{return hitbox;}
            set{Hitbox=value;}
        }

        public Box(Texture2D texture, Vector2 startPosition)
        {
            this.texture = texture;
            position = startPosition;
            hitbox = new Rectangle(0,0,30,50);
            color = Color.White;
        }

        public abstract void Update();
        
        public virtual void Draw(SpriteBatch spriteBatch){
            spriteBatch.Draw(texture,hitbox,color);
        }
    }
}