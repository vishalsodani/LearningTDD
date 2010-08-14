using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{
    class Frame
    {
        int _score;
        int _noofthrows;

        public int Score { get; set; }


        internal void PinsFallen(int p)
        {
            _score += p;
            _noofthrows += 1;
        }

        public  bool IsSpare()
        {
            return _score == 10 && _noofthrows == 2;
        }

        public bool IsStrike()
        {
            return _score == 10 && _noofthrows == 1;
        }


        internal bool IsFirstThrow()
        {
            return _noofthrows == 1;
        }

        internal bool IsSecondThrow()
        {
            return _noofthrows == 2;
        }
    }
}
