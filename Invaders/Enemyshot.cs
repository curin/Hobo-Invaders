using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace Invaders
{
    class Enemyshot
    {

         Vector2 _location;
        Texture2D _tex;
        int _speed = 3;

        private int _framecount = 0;
        private double _elapsedseconds = 0.0;


        public Enemyshot(Vector2 location, Texture2D tex)
        {
            _location = location;
            _tex = tex;
        }

        public Vector2 Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }

        public Texture2D shotTexture
        {
            set
            {
                _tex = value;
            }

            get
            {
                return _tex;
            }
        }

        public void Move()
        {
            _location.Y += _speed;
        }

        public int FrameCount
        {
            get
            {
                return _framecount;
            }

            set
            {
                _framecount = value;
            }
        }

        public Double ElapsedSeconds
        {
            get
            {
                return _elapsedseconds;
            }

            set
            {
                _elapsedseconds = value;
            }
        }

        public bool checkforCollision(Vector2 colLocation, int colWidth, int colHeight)
        {
            bool collision = false;
            Rectangle rect = new Rectangle((int)_location.X, (int)_location.Y, _tex.Height, _tex.Height);
            Rectangle rect2 = new Rectangle((int)colLocation.X - 2, (int)colLocation.Y, colWidth + 4, colHeight);
            rect.Intersects(ref rect2, out collision);

          /*  
                if (((colLocation.X > _location.X && colLocation.X < _location.X + _tex.Height) || (colLocation.X + colWidth > _location.X && colLocation.X + colWidth < _location.X + _tex.Height)) && colLocation.Y < _location.Y + _tex.Height)
                {
                      collision = true;
                }
            */

            return collision;
        }

    }
}
