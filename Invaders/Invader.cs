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
    public class Invader
    {
        #region private Variables

        private Vector2 _location;
        private type _type;
        private int _framecount = 0;
        private double _elapsedseconds = 0.0;


        #endregion


        // defining the types of Invaders
        public enum type
        {
            dead = 0,
            hobo = 1,
            low,
            middle,
            high,
            moneybags
        }

        // public constructor
        public Invader()
        {
            _type = type.hobo;
        }

        public Invader(type t)
        {
            _type = t;
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

        public type Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
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

        public bool CheckCollision(Vector2 colLocation, int colWidth, int colHeight)
        {
            bool collision = false;
            Rectangle rect = new Rectangle((int)_location.X, (int)_location.Y, 30, 30);
            Rectangle rect2 = new Rectangle((int)colLocation.X, (int)colLocation.Y, colWidth, colHeight);
            rect.Intersects(ref rect2, out collision);

            collision = collision && _type != Invader.type.dead;

            if (collision)
            {
                _type = _type - 1;
            }

            return collision;
        }

    }
}
