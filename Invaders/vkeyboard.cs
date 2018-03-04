using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Invaders
{
    class vkeyboard
    {
        public WriteableString ws = new WriteableString();
        public KeyboardState keb;
        public string keyboard(string st)
        {
            keb = Keyboard.GetState();
            st = key0(st);
            st = key1(st);
            st = key2(st);
            st = key3(st);
            st = key4(st);
            st = key5(st);
            st = key6(st);
            st = key7(st);
            st = key8(st);
            st = key9(st);
            st = keymin(st);
            st = keypl(st);
            st = keyback(st);
            st = keyspace(st);
            st = row1(st);
            st = row2(st);
            st = row3(st);
            return st;
        }
        public string row1(string st)
        {
            st = keyQ(st);
            st = keyW(st);
            st = keyE(st);
            st = keyR(st);
            st = keyT(st); 
            st = keyY(st);
            st = keyU(st);
            st = keyI(st);
            st = keyO(st);
            st = keyP(st);
            st = keybr(st);
            st = keybrc(st);
            st = keybacks(st);
            st = keyspace(st);
            return st;
        }
        public string row2(string st)
        {
            st = keyA(st);
            st = keyS(st);
            st = keyD(st);
            st = keyf(st);
            st = keyg(st);
            st = keyh(st);
            st = keyj(st);
            st = keyk(st);
            st = keyl(st);
            st = keysemi(st);
            st = keyquote(st);
            return st;
        }
        public string row3(string st)
        {
            st = keyz(st);
            st = keyx(st);
            st = keyc(st);
            st = keyv(st);
            st = keyb(st);
            st = keyn(st);
            st = keym(st);
            st = keycomma(st);
            st = keyperiod(st);
            st = keyqa(st);
            return st;
        }
        public string keyA(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift)||keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.A))
                {
                    st =  ws.addtostring(st, "A");
                }
            }
             else {  if (keb.IsKeyDown(Keys.A))
            {
                st =  ws.addtostring(st, "a");
            }

            }return st;
        }
        public string key1(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad1))
                {
                    st =  ws.addtostring(st, "!");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad1))
            {
                st =  ws.addtostring(st, "1");
            }
            }return st;
        }
        public string key2(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad2))
                {
                    st =  ws.addtostring(st, "@");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad2))
            {
                st =  ws.addtostring(st, "2");
            }
            }return st;
        }
        public string key3(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad3))
                {
                    st =  ws.addtostring(st, "#");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad3))
            {
                st =  ws.addtostring(st, "3");
            }
            }return st;
        }
        public string key4(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad4))
                {
                    st =  ws.addtostring(st, "$");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad4))
            {
                st =  ws.addtostring(st, "4");
            }
            }return st;
        }
        public string key5(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad5))
                {
                    st =  ws.addtostring(st, "%");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad5))
            {
                st =  ws.addtostring(st, "5");
            }
            }return st;
        }
        public string key6(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad6))
                {
                    st =  ws.addtostring(st, "^");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad6))
            {
                st =  ws.addtostring(st, "6");
            }
            }return st;
        }
        public string key7(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad7))
                {
                    st =  ws.addtostring(st, "&");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad7))
            {
                st =  ws.addtostring(st, "7");
            }
            }return st;
        }
        public string key8(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad8))
                {
                    st =  ws.addtostring(st, "*");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad8))
            {
                st =  ws.addtostring(st, "8");
            }
            }return st;
        }
        public string key9(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad9))
                {
                    st =  ws.addtostring(st, "(");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad9))
            {
                st =  ws.addtostring(st, "9");
            }
            }return st;
        }
        public string key0(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.NumPad0))
                {
                    st =  ws.addtostring(st, ")");
                }
            }
             else {  if (keb.IsKeyDown(Keys.NumPad0))
            {
                st =  ws.addtostring(st, "0");
            }
            }return st;
        }
        public string keyQ(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.Q))
                {
                    st =  ws.addtostring(st, "Q");
                }
            }
             else {  if (keb.IsKeyDown(Keys.Q))
            {
                st =  ws.addtostring(st, "q");
            }
            }return st;
        }
        public string keyW(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.W))
                {
                    st =  ws.addtostring(st, "W");
                }
            }
             else {  if (keb.IsKeyDown(Keys.W))
            {
                st =  ws.addtostring(st, "w");
            }
            }return st;
        }
        public string keyE(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.E))
                {
                    st =  ws.addtostring(st, "E");
                }
            }
             else {  if (keb.IsKeyDown(Keys.E))
            {
                st =  ws.addtostring(st, "e");
            }
            }return st;
        }
        public string keyR(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.R))
                {
                    st =  ws.addtostring(st, "R");
                }
            }
             else {  if (keb.IsKeyDown(Keys.R))
            {
                st =  ws.addtostring(st, "r");
            }
            }return st;
        }
        public string keyT(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.T))
                {
                    st =  ws.addtostring(st, "T");
                }
            }
             else {  if (keb.IsKeyDown(Keys.T))
            {
                st =  ws.addtostring(st, "t");
            }
            }return st;
        }
        public string keyY(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.Y))
                {
                    st =  ws.addtostring(st, "Y");
                }
            }
             else {  if (keb.IsKeyDown(Keys.Y))
            {
                st =  ws.addtostring(st, "y");
            }
            }return st;
        }
        public string keyU(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.U))
                {
                    st =  ws.addtostring(st, "U");
                }
            }
             else {  if (keb.IsKeyDown(Keys.U))
            {
                st =  ws.addtostring(st, "u");
            }
            }return st;
        }
        public string keyI(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.I))
                {
                    st =  ws.addtostring(st, "I");
                }
            }
             else {  if (keb.IsKeyDown(Keys.I))
            {
                st =  ws.addtostring(st, "i");
            }
            }return st;
        }
        public string keyO(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.O))
                {
                    st =  ws.addtostring(st, "O");
                }
            }
             else {  if (keb.IsKeyDown(Keys.O))
            {
                st =  ws.addtostring(st, "o");
            }
            }return st;
        }
        public string keyP(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.P))
                {
                    st =  ws.addtostring(st, "P");
                }
            }
             else {  if (keb.IsKeyDown(Keys.P))
            {
                st =  ws.addtostring(st, "p");
            }
            }return st;
        }
        public string keybr(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemOpenBrackets))
                {
                    st =  ws.addtostring(st, "{");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemOpenBrackets))
            {
                st =  ws.addtostring(st, "[");
            }
            }return st;
        }
        public string keybrc(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemCloseBrackets))
                {
                    st =  ws.addtostring(st, "}");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemCloseBrackets))
            {
                st =  ws.addtostring(st, "]");
            }
            }return st;
        }
        public string keymin(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemMinus))
                {
                    st =  ws.addtostring(st, "_");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemMinus))
            {
                st =  ws.addtostring(st, "-");
            }
            }return st;
        }
        public string keypl(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemPlus))
                {
                    st =  ws.addtostring(st, "+");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemPlus))
            {
                st =  ws.addtostring(st, "=");
            }
            }return st;
        }
        public string keybacks(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemBackslash))
                {
                    st =  ws.addtostring(st, "|");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemBackslash))
            {
                st =  ws.addtostring(st, @"\");
            }
            }return st;
        }
        public string keysemi(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemSemicolon))
                {
                    st =  ws.addtostring(st, ":");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemSemicolon))
            {
                st =  ws.addtostring(st, ";");
            }
            }return st;
        }
        public string keytilde(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemTilde))
                {
                    st =  ws.addtostring(st, "~");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemTilde))
            {
                st =  ws.addtostring(st, "`");
            }
            }return st;
        }
        public string keyquote(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemQuotes))
                {
                    st =  ws.addtostring(st, "");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemQuotes))
            {
                st =  ws.addtostring(st, "'");
            }
            }return st;
        }
        public string keycomma(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemComma))
                {
                    st =  ws.addtostring(st, "<");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemComma))
            {
                st =  ws.addtostring(st, ",");
            }
            }return st;
        }
        public string keyperiod(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemPeriod))
                {
                    st =  ws.addtostring(st, ">");
                }
            }
             else {  if (keb.IsKeyDown(Keys.OemPeriod))
            {
                st =  ws.addtostring(st, ".");
            }
            }return st;
        }
        public string keyqa(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.OemQuestion))
                {
                    st =  ws.addtostring(st, "?");
                }
            }
            else
            {
                if (keb.IsKeyDown(Keys.OemQuestion))
                {
                    st =  ws.addtostring(st, "/");
                }
            }
            return st;
        }
        public string keyback(string st)
        {
            keb = Keyboard.GetState(); 
            if (keb.IsKeyDown(Keys.Back))
            {
                st = ws.removelast(st);
            }
            return st;
        }
        public string keyS(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.S))
                {
                    st =  ws.addtostring(st, "S");
                }
            }
             else {  if (keb.IsKeyDown(Keys.S))
            {
                st =  ws.addtostring(st, "s");
            }
            }return st;
        }
        public string keyD(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.D))
                {
                    st =  ws.addtostring(st, "D");
                }
            }
             else {  if (keb.IsKeyDown(Keys.D))
            {
                st =  ws.addtostring(st, "d");
            }
            }return st;
        }
        public string keyf(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.F))
                {
                    st =  ws.addtostring(st, "F");
                }
            }
             else {  if (keb.IsKeyDown(Keys.F))
            {
                st =  ws.addtostring(st, "f");
            }
            }return st;
        }
        public string keyg(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.G))
                {
                    st =  ws.addtostring(st, "G");
                }
            }
             else {  if (keb.IsKeyDown(Keys.G))
            {
                st =  ws.addtostring(st, "g");
            }
            }return st;
        }
        public string keyh(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.H))
                {
                    st =  ws.addtostring(st, "H");
                }
            }
             else {  if (keb.IsKeyDown(Keys.H))
            {
                st =  ws.addtostring(st, "h");
            }
            }return st;
        }
        public string keyj(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.J))
                {
                    st =  ws.addtostring(st, "J");
                }
            }
             else {  if (keb.IsKeyDown(Keys.J))
            {
                st =  ws.addtostring(st, "j");
            }
            }return st;
        }
        public string keyk(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.K))
                {
                    st =  ws.addtostring(st, "K");
                }
            }
             else {  if (keb.IsKeyDown(Keys.K))
            {
                st =  ws.addtostring(st, "k");
            }
            }return st;
        }
        public string keyl(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.L))
                {
                    st =  ws.addtostring(st, "L");
                }
            }
             else {  if (keb.IsKeyDown(Keys.L))
            {
                st =  ws.addtostring(st, "l");
            }
            }return st;
        }
        public string keyz(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.Z))
                {
                    st =  ws.addtostring(st, "Z");
                }
            }
             else {  if (keb.IsKeyDown(Keys.Z))
            {
                st =  ws.addtostring(st, "z");
            }
            }return st;
        }
        public string keyx(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.X))
                {
                    st =  ws.addtostring(st, "X");
                }
            }
             else {  if (keb.IsKeyDown(Keys.X))
            {
                st =  ws.addtostring(st, "x");
            }
            }return st;
        }
        public string keyc(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.C))
                {
                    st =  ws.addtostring(st, "C");
                }
            }
             else {  if (keb.IsKeyDown(Keys.C))
            {
                st =  ws.addtostring(st, "c");
            }
            }return st;
        }
        public string keyv(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.V))
                {
                    st =  ws.addtostring(st, "V");
                }
            }
             else {  if (keb.IsKeyDown(Keys.V))
            {
                st =  ws.addtostring(st, "v");
            }
            }return st;
        }
        public string keyb(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.B))
                {
                    st =  ws.addtostring(st, "B");
                }
            }
             else {  if (keb.IsKeyDown(Keys.B))
            {
                st =  ws.addtostring(st, "b");
            }
            }return st;
        }
        public string keyn(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.N))
                {
                    st =  ws.addtostring(st, "N");
                }
            }
             else {  if (keb.IsKeyDown(Keys.N))
            {
                st =  ws.addtostring(st, "n");
            }
            }return st;
        }
        public string keym(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.LeftShift) || keb.IsKeyDown(Keys.RightShift))
            {
                if (keb.IsKeyDown(Keys.M))
                {
                    st =  ws.addtostring(st, "M");
                }
            }
             else {  if (keb.IsKeyDown(Keys.M))
            {
                st =  ws.addtostring(st, "m");
            }
            }return st;
        }
        public string keyspace(string st)
        {
            keb = Keyboard.GetState();
            if (keb.IsKeyDown(Keys.Space))
            {
                st =  ws.addtostring(st, " ");
            }
            return st;
        }
    }
}
