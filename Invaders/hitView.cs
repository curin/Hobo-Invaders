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
    class hitView
    {
        Vector2 _location;
        int _score;

        public hitView(Vector2 location)
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

        public int Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = value;
            }
        }

        public void Move()
        {
            _location.Y -= 0.2f;
            _location.X += 0.2f;
        }


    }
}
