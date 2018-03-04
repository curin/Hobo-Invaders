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
    class Explosion
    {
        private Vector2 _location;

        private Texture2D _texture;

        private int _framecount = 0;
        private double _elapsedseconds = 0.0;

        public Explosion(Vector2 location)
        {
            _location = location;
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
        public Texture2D Texture
        {
            get
            {
                return _texture;
            }
            set
            {
                _texture = value;
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
    }

}
