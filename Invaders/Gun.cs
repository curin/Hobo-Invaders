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
    class Gun
    {
        private Texture2D _texture = null;
        private Vector2 _location;
        private float _speed = 0;
        private float _speed2 = 0;

        public Gun(Vector2 location)
        {
            _location = location;
        }

        public Texture2D gunTexture
        {
            set
            {
                _texture = value;
            }

            get
            {
                return _texture;
            }
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

        public void MoveLeft(float speed)
        {
            _speed -= speed;
        }

        public void MoveRight(float speed)
        {
            _speed += speed;
        }

        public float Move()
        {
            _location.X += _speed;
            if (_location.X > 770)
            {
                _location.X = 770;
                _speed = 0;
            }
            if(_location.X < 0)
            {
                _location.X = 0;
                _speed = 0;
            }

            return _speed;
        }

        public void MovetoX(int x)
        {
            _location.X = x;
        }

        public void Stop()
        {
            _speed = 0;
        }

        public bool checkforCollision(Vector2 colLocation, int colWidth, int colHeight)
        {
            bool collision = false;
            Rectangle rect = new Rectangle((int)_location.X, (int)_location.Y, 30, 30);
            Rectangle rect2 = new Rectangle((int)colLocation.X, (int)colLocation.Y, colWidth, colHeight);
            rect.Intersects(ref rect2, out collision);

            return collision;
        }

       
        public void MoveUp(float howfastisit2)
        {
            _speed2 -= howfastisit2;
        }
        public void MoveDown(float howfastisit2)
        {
            _speed2 += howfastisit2;
        }

        public float move2()
        {
            _location.Y += _speed2;
            if (_location.Y > 570)
            {
                _location.Y = 570;
                _speed2 = 0;
            }
            if (_location.Y < 0)
            {
                _location.Y = 0;
                _speed2 = 0;
            }
            return _speed2;
        }
        public void Stop2()
        {
            _speed2 = 0;
        }
    }
}
