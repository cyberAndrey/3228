using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Observer
{
    class Simulator
    {
        public bool Top { get; set; } = true;
        public bool Bot { get; set; } = true;
        public bool Left { get; set; } = true;
        public bool Right { get; set; } = true;

        public string[] GetState()
        {
            string[] moves = { Top.ToString(), Right.ToString(), Bot.ToString(), Left.ToString()};
            //string s = $"{Top}.{Right}.{Bot}.{Left}";
            return moves;
        }
    }
}
