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
    class Shield
    {
        Vector2 _location;
        Texture2D _tex;
        int _damageFL = 100;
        int _damageL = 100;
        int _damageLC = 100;
        int _damageC = 100;
        int _damageRC = 100;
        int _damageR = 100;
        int _damageFR = 100;

        public Shield(Vector2 location, Texture2D tex)
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

        public Texture2D ShieldTexture
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

        public int FarLeft
        {
            get
            {
                return _damageFL;
            }

            set
            {
                _damageFL = value;
            }
        }

        public int Left
        {
            get
            {
                return _damageL;
            }

            set
            {
                _damageL = value;
            }
        }

        public int LeftCenter
        {
            get
            {
                return _damageLC;
            }

            set
            {
                _damageLC = value;
            }
        }

        public int Center
        {
            get
            {
                return _damageC;
            }

            set
            {
                _damageC = value;
            }
        }

        public int RightCenter
        {
            get
            {
                return _damageRC;
            }

            set
            {
                _damageRC = value;
            }
        }

        public int Right
        {
            get
            {
                return _damageR;
            }

            set
            {
                _damageR = value;
            }
        }

        public int FarRight
        {
            get
            {
                return _damageFR;
            }

            set
            {
                _damageFR = value;
            }
        }
        public bool checkCollision(Vector2 colLocation, int colWidth, int colHeight)
        {
            bool collision = false;
            bool returnValue = false;
            Rectangle rect = new Rectangle((int)_location.X, (int)_location.Y, _tex.Width / 7, _tex.Height);
            Rectangle rect2 = new Rectangle((int)colLocation.X, (int)colLocation.Y, colWidth, colHeight);
            rect.Intersects(ref rect2, out collision);
            if (collision && _damageFL > 0)
            {
                _damageFL -= 10;
                returnValue = true;
            }

            rect = new Rectangle((int)_location.X + _tex.Width / 7, (int)_location.Y, _tex.Width / 7, _tex.Height);
            rect.Intersects(ref rect2, out collision);
            if (collision && _damageL > 0)
            {
                _damageL -= 10;
                returnValue = true;
            }

            rect = new Rectangle((int)_location.X + (_tex.Width / 7) * 2, (int)_location.Y, _tex.Width / 7, _tex.Height);
            rect.Intersects(ref rect2, out collision);
            if (collision && _damageLC > 0)
            {
                _damageLC -= 10;
                returnValue = true;
            }

            rect = new Rectangle((int)_location.X + (_tex.Width / 7) * 3, (int)_location.Y, _tex.Width / 7, _tex.Height);
            rect.Intersects(ref rect2, out collision);
            if (collision && _damageC > 0)
            {
                _damageC -= 10;
                returnValue = true;
            }

            rect = new Rectangle((int)_location.X + (_tex.Width / 7) * 4, (int)_location.Y, _tex.Width / 7, _tex.Height);
            rect.Intersects(ref rect2, out collision);
            if (collision && _damageRC > 0)
            {
                _damageRC -= 10;
                returnValue = true;
            }

            rect = new Rectangle((int)_location.X + (_tex.Width / 7) * 5, (int)_location.Y, _tex.Width / 7, _tex.Height);
            rect.Intersects(ref rect2, out collision);
            if (collision && _damageR > 0)
            {
                _damageR -= 10;
                returnValue = true;
            }

            rect = new Rectangle((int)_location.X + (_tex.Width / 7) * 6, (int)_location.Y, _tex.Width / 7, _tex.Height);
            rect.Intersects(ref rect2, out collision);
            if (collision && _damageFR > 0)
            {
                _damageFR -= 10;
                returnValue = true;
            }

            return returnValue;
        }
        public void resetsheilds()
        {
             _damageFL = 100;
             _damageL = 100;
             _damageLC = 100;
             _damageC = 100;
             _damageRC = 100;
             _damageR = 100;
             _damageFR = 100;
        }

        public void sheildregen(int regeneration)
        {
            _damageFL += regeneration;
            _damageL += regeneration;
            _damageLC += regeneration;
            _damageC += regeneration;
            _damageRC += regeneration;
            _damageR += regeneration;
            _damageFR += regeneration;


        }
        public void savesheild(Savegame sg)
        {
            sg.damageC = _damageC;
            sg.damageL = _damageL;
            sg.damageFL = _damageFL;
            sg.damageR = _damageR;
            sg.damageFR = _damageFR;
            sg.damageRC = _damageRC;
            sg.damageLC = _damageLC;
        }
        public void loadsheild(Savegame sg)
        {
            _damageC = sg.damageC;
            _damageL = sg.damageL;
            _damageFL = sg.damageFL;
            _damageR = sg.damageR;
            _damageFR = sg.damageFR;
            _damageRC = sg.damageRC;
            _damageLC = sg.damageLC;
        }
    }
}
