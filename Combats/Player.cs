using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combats
{
    public enum PeaceOfBody : byte { Head = 0, Body, Legs };

    public class Player
    {
        public string Name { get; }
        public double Hp { get; set; }
        private PeaceOfBody blocked;
        private delegate double PlayerStateHandler(string message);
        private event PlayerStateHandler Block;
        private event PlayerStateHandler Wound;
        private event PlayerStateHandler Death;

        public Player()
        {
            Hp = 100;
        }

        public Player(string name)
        {
            Name = name;
            Hp = 100;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodyType"></param>
        public void SetBlock(PeaceOfBody bodyType)
        {
            blocked = bodyType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodyNum"></param>
        public void GetHit(PeaceOfBody bodyNum)
        {
            if (Hp < 100)
            {
                Death($"You are dead {Name}.");
            }
            else if (bodyNum != blocked)
            {
                Hp = Hp - 10;
                Wound($"It hurts.");
            }
            else Block("Next time you hit me.");
        }
    }
}
