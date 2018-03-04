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
    class Laser
    {
        Vector2 _location;
        Texture2D _tex;
        int _speed = 5;

        public Laser(Vector2 location, Texture2D tex)
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

        public Texture2D LaserTexture
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
            _location.Y -= _speed;
        }

    }
}
