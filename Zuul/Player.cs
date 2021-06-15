using System;
using System.Collections.Generic;
using System.Text;

namespace Zuul
{
    public class Player
    {
        public Room CurrentRoom { get; set; }
        private int health;
        public Player()
        {
            CurrentRoom = null;
            health = 100;
        }
    }
}