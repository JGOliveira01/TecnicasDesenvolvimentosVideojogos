using IPCA.Monogame;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    internal class Player
    {
        private KeyboardManager _keyboardManager;
        //public Player(KeyboardManager km) 
        //{
        //    _keyboardManager = km;
        //}
        public Player()
        {
            KeyboardManager.Register(Keys.Space, KeysState.GoingDown, () => Console.WriteLine("Space is Going Down!!!"));

            KeyboardManager.Register(Keys.Space, KeysState.Down, () => Console.WriteLine("Space is Down"));

            KeyboardManager.Register(Keys.Space, KeysState.GoingUp, () => Console.WriteLine("Space is going Up!"));
        }


        //public void Update()
        //{
        //    //if (_keyboardManager.IsGoingDown(Keys.Space))
        //    if (KeyboardManager.IsGoingDown(Keys.Space))
        //    {
        //Console.WriteLine("Space is Going Down");
        //}
        //      //if (_keyboardManager.IsKeyDown(Keys.Space))
        //    if (KeyboardManager.IsKeyDown(Keys.Space))
        //    {
        //Console.WriteLine("Space is Down");
        //}
        //    //if (_keyboardManager.IsGoingUp(Keys.Space))
        //    if (KeyboardManager.IsGoingUp(Keys.Space))
        //    {
        //Console.WriteLine("Space is Going Up");
        //}

    }
}