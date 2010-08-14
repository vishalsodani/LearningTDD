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

        public void PinsFallen(int p)
        {

            
             _currentFrame.PinsFallen(p);

             if (_previousFrame != null && _previousFrame.IsStrike())
             {
                 AddPinsToTotalScore(p);
             }

            if (_previousFrame!=null && _previousFrame.IsSpare() && _currentFrame.IsFirstThrow() )
            {
                IncrementScoreForSpare(p);
                
            }
            
            else
            {
                AddPinsToTotalScore(p);
            }


            ChangeFrame();
          
           
            
        }

        private int AddPinsToTotalScore(int p)
        {
            return _score += p;
        }

        private void IncrementScoreForSpare(int p)
        {
            _score += 2 * p;
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
