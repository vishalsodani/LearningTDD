using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{
    public class BowlingKata
    {
        int _score;


        Frame _currentFrame;
        Frame _previousFrame;

        public int score { get { return _score; } }


        public BowlingKata()
        {
            _currentFrame = new Frame();
            _previousFrame = new Frame();

        }

        public void PinsFallen(int pinsFallen)
        {


            _currentFrame.PinsFallen(pinsFallen);


            if (_previousFrame.IsStrike() && _currentFrame.HasThrows())
            {
                AddPinsToTotalScore(pinsFallen);
            }

            if (_previousFrame.IsSpare() && _currentFrame.IsFirstThrow())
            {
                AddPinsToTotalScore(pinsFallen);

            }


           AddPinsToTotalScore(pinsFallen);
           ChangeFrame();

        }

        private int AddPinsToTotalScore(int pinsFallen)
        {
            return _score += pinsFallen;
        }


        private void ChangeFrame()
        {
            if (_currentFrame.IsSecondThrow() || _currentFrame.IsStrike())
            {
                Initialize();
            }

        }

        private void Initialize()
        {
            _previousFrame = _currentFrame;
            _currentFrame = new Frame();

        }





    }



}
