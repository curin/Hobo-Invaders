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
    public class InvaderShip
    {

        Vector2 _location;
        double _speed = 2f;
        type _type = type.Luke;
        bool _active = false;
        // defining the types of Invaders
        public enum type
        {
            Luke = 0,
            Matt = 1,
            Luke1,
            Matt1,
            Luke2,
            Andrew1,
            Lorin1,
            Andrew2,
            Dan1,
            Lorin2,
            Dan2,
            Lorin,
            Andrew,
            Tim,
            Dan,
            Jeff
        }

        public InvaderShip(Vector2 location, type Type)
        {
            _location = location;
            _type = Type;
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

        public bool Active
        {
            set
            {
                _active = value;
            }

            get
            {
                return _active;
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

        public double Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
                if (_speed > 6)
                {
                    _speed = 6;
                }
            }
        }

        public void Move()
        {
            _location.X += (int)_speed;
        }


        public bool checkforCollision(Vector2 colLocation, int colWidth, int colHeight)
        {
            bool collision = false;
            Rectangle rect = new Rectangle((int)_location.X, (int)_location.Y, 30, 30);
            Rectangle rect2 = new Rectangle((int)colLocation.X, (int)colLocation.Y, colWidth, colHeight);
            rect.Intersects(ref rect2, out collision);

            return collision;
        }

    }
}
