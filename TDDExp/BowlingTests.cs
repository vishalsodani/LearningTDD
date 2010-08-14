using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;
using Bowling;

namespace TDDExp
{
    [TestFixture] 
    public class BowlingTests
    {
        BowlingKata kata;

        [SetUp]
        public void Initialize()
        {
            kata = new BowlingKata();
        }

        [Test]
        public void ScoreShouldBeZeroWhenGameBegins()
        {
            Assert.AreEqual(0, kata.score);
        }

        [Test]
        public void ScoreShouldBe7()
        {
            kata.PinsFallen(7);
            Assert.AreEqual(7, kata.score);
        }

        [Test]
        public void ScoreShouldBe24_WhenSpareIsFollowedByRegularThrow()
        {
            CreateSpare();
            kata.PinsFallen(7);

            Assert.AreEqual(24, kata.score);

        }

        private void CreateSpare()
        {
            kata.PinsFallen(5);
            kata.PinsFallen(5);
        }

        [Test]
        public void ScoreShouldBe39_When2SparesAreFollowedByARegularThrow()
        {
            CreateSpare();
            CreateSpare();
            kata.PinsFallen(7);

            Assert.AreEqual(39, kata.score);
             

        }

        [Test]
        public void ScoreShouldBe24_WhenStrikeIsFollowedByRegularThrows()
        {
            CreateStrike();
            kata.PinsFallen(3);
            kata.PinsFallen(4);

            Assert.AreEqual(24, kata.score);
    
        }

        [Test]
        public void ScoreShouldBe40_WhenStrikeIsFollowedBySpareAndRegularThrows()
        {
            CreateStrike();
            CreateSpare();
            kata.PinsFallen(3);
            kata.PinsFallen(4);

            Assert.AreEqual(40, kata.score);

        }

        private void CreateStrike()
        {
            kata.PinsFallen(10);
        }

        

    }
}
