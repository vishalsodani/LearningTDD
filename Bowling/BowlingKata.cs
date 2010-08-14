using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{
    public class BowlingKata
    {
        int _score;

        List<Frame> framesList = new List<Frame>();
        Frame _currentFrame;
        Frame _previousFrame;

        public int score { get { return _score; }  }


        public BowlingKata()
        {
            _currentFrame = new Frame();
            framesList.Add(_currentFrame);   
        }

        public void PinsFallen(int pinsFallen)
        {


            _currentFrame.PinsFallen(pinsFallen);

             if (_previousFrame != null && _previousFrame.IsStrike())
             {
                 AddPinsToTotalScore(pinsFallen);
             }

            if (_previousFrame!=null && _previousFrame.IsSpare() && _currentFrame.IsFirstThrow() )
            {
                IncrementScoreForSpare(pinsFallen);
                
            }
            
            else
            {
                AddPinsToTotalScore(pinsFallen);
            }


            ChangeFrame();
          
           
            
        }

        private int AddPinsToTotalScore(int pinsFallen)
        {
            return _score += pinsFallen;
        }

        private void IncrementScoreForSpare(int pinsFallen)
        {
            _score += 2 * pinsFallen;
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
            framesList.Add(_currentFrame);

        }

       

     

    }



}
