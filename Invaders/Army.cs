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
    class Army
    {
        private Random rand = new Random();
        private Vector2 _location = new Vector2(0,40);
        private int movedir = 1;
        private bool halfMove = false;
        private Texture2D[] _skin = new Texture2D[6];
        
        public Invader[,] soldier = new Invader[15,6];


        public Army()
        {
            float width = 0;
            for (int x = 0; x < 15; x++)
            {
                width = (float)(x * 40);
                for (int y = 0; y < 6; y++)
                {
                    soldier[x, y] = new Invader( Invader.type.hobo);
                    soldier[x, y].FrameCount = rand.Next(0, 4);

                    soldier[x, y].Location = new Vector2(width, (y * 40) + 40);
                }
            }
        }

        public void resetArmy( int level, Invader.type type,  Invader.type type1,  Invader.type type2,  Invader.type type3,  Invader.type type4,  Invader.type type5)
        {
            _location = new Vector2(0, 40);
            float width = 0;
            for (int x = 0; x < 15; x++)
            {
                width = (float)(x * 40);
                for (int y = 0; y < 6; y++)
                {
                    soldier[x, 0].Type = type;
                    soldier[x, 1].Type = type1;
                    soldier[x, 2].Type = type2;
                    soldier[x, 3].Type = type3;
                    soldier[x, 4].Type = type4;
                    soldier[x, 5].Type = type5;
                    soldier[x, y].FrameCount = rand.Next(0, 4);

                    soldier[x, y].Location = new Vector2(width, (y * 40) + 40);
                }
            }
        }

        public bool moveArmy()
        {
            bool dropdown = false;
            int testColumn = 0;
            if (movedir > 0)
            {
                //find right most column with at least one invader
                for (int x = 14; x > -1; x--)
                {
                    for (int y = 0; y < 6; y++)
                    {
                        if (soldier[x, y].Type != Invader.type.dead)
                        {
                            testColumn = x + 1;
                            y = 6;
                            x = -1;
                        }
                    }
                }
            }
            else
            {
                //find right most column with at least one invader
                for (int x = 0; x < 15; x++)
                {
                    for (int y = 0; y < 6; y++)
                    {
                        if (soldier[x, y].Type != Invader.type.dead)
                        {
                            testColumn = x;
                            y = 6;
                            x = 15;
                        }
                    }
                }
            }

            if (_location.X + (40 * testColumn) + 20 > 800 || _location.X + (40 * testColumn) - 20 < 0)
            {
                movedir *= -1;
                _location.Y += 20;
                dropdown = true;
            }
            else
            {
                if (halfMove)
                {
                    _location.Y += 5;
                }
                else
                {
                    _location.Y -= 5;
                }

                halfMove = !halfMove;

                _location.X += (10 * movedir);
            }
            setArmyLocation();

            return dropdown;
        }

        private void setArmyLocation()
        {
            float width = 0;
            for (int x = 0; x < 15; x++)
            {
                width = (float)(x * 40 + _location.X);
                for (int y = 0; y < 6; y++)
                {
                    soldier[x, y].Location = new Vector2(width, (y * 40) + _location.Y);
                }
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

        public Texture2D getTexture(ref Invader invader)
        {
            return _skin[(int)invader.Type];
        }

        public void setTexture(Invader.type type, Texture2D tex)
        {
            _skin[(int)type] = tex;
        }

        public bool checkforCollision(Vector2 colLocation, int colWidth, int colHeight)
        {
           // bool collisionx = false;
           // bool collisiony = false;
            bool collision = false;

            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                   // collisionx = colLocation.X < soldier[x, y].Location.X && colLocation.X < soldier[x, y].Location.X + 30;
                   // collisiony = colLocation.Y < soldier[x, y].Location.Y && colLocation.Y < soldier[x, y].Location.Y + 30;
                    Rectangle rect = new Rectangle((int)soldier[x, y].Location.X, (int)soldier[x, y].Location.Y, 30,  30);
                    Rectangle rect2 = new Rectangle((int)colLocation.X, (int)colLocation.Y, colWidth, colHeight);
                   rect.Intersects(ref rect2, out collision);

                    if (collision && soldier[x, y].Type != Invader.type.dead)
                    {
                        soldier[x, y].Type = soldier[x, y].Type - 1;
                    }
                }
            }

            return collision;
        }

        public bool checkInvaderStatus()
        {
            bool finished = true;
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (soldier[x, y].Type != Invader.type.dead)
                    {
                        finished = false;
                    }
                }
            }

            return finished;
        }

        public bool CheckInvaderWin(int bottom)
        {
            Vector2 lowest = new Vector2(0, 0);
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (soldier[x, y].Type != Invader.type.dead)
                    {
                        if (lowest.Y < y)
                        {
                            lowest.Y = y;
                            lowest.X = x;
                        }
                    }
                }
            }

            if (soldier[(int)lowest.X, (int)lowest.Y].Location.Y > bottom)
            {
                return true;
            }

            return false;
        }

        public void nukedamage()
        {
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    int life = (int)soldier[x, y].Type;
                    life -= 3;
                    if (life < 0)
                    {
                        life = 0;
                    }
                    soldier[x, y].Type = (Invader.type)life;
                }
            }
        }
        public void invaderupdate(int column ,Invader.type type)
        {
            for (int x = 0; x < 15; x++)
            {
                soldier[x, column].Type = type;
            }
        }
    }
}
