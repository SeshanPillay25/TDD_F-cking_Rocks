using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SpockGame;

namespace SpockGameTests
{

   [TestFixture]
    public class GameTests
    {
        [Test]
        public void ScissorsCutPaper()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Scissors, Play.Paper));
        }

        [Test]
        public void PaperIsCutByScissors()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Paper, Play.Scissors));
        }

        [Test]
        public void Ties()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.Tie, game.DoPlay(Play.Paper, Play.Paper));
            Assert.AreEqual(PlayResult.Tie, game.DoPlay(Play.Scissors, Play.Scissors));
            Assert.AreEqual(PlayResult.Tie, game.DoPlay(Play.Spock, Play.Spock));
            Assert.AreEqual(PlayResult.Tie, game.DoPlay(Play.Lizard, Play.Lizard));
            Assert.AreEqual(PlayResult.Tie, game.DoPlay(Play.Rock, Play.Rock));
        }

        [Test]
        public void PaperCoversRock()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Paper, Play.Rock));
        }

        [Test]
        public void RockIsCoveredByPaper()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Rock, Play.Paper));
        }

        [Test]
        public void RockCrushesLizard()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Rock, Play.Lizard));
        }

        [Test]
        public void LizardIsCrushedByRock()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Lizard, Play.Rock));
        }

        [Test]
        public void LizardPoisonsSpock()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Lizard, Play.Spock));
        }

        [Test]
        public void SpockIsPoisonedByLizard()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Spock, Play.Lizard));
        }

        [Test]
        public void SpockSmashesScissors()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Spock, Play.Scissors));
        }

        [Test]
        public void ScissorsAreSmashedBySpock()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Scissors, Play.Spock));
        }

        [Test]
        public void ScissorsDecapiteLizard()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Scissors, Play.Lizard));
        }

        [Test]
        public void LizardIsDecapitedByScissors()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Lizard, Play.Scissors));
        }

        [Test]
        public void LizardEatsPaper()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Lizard, Play.Paper));
        }

        [Test]
        public void PaperIsEatenByLizard()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Paper, Play.Lizard));
        }

        [Test]
        public void PaperDisprovesSpock()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Paper, Play.Spock));
        }

        [Test]
        public void SpockIsDisprovedByPaper()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Spock, Play.Paper));
        }

        [Test]
        public void SpockVaporizesRock()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Spock, Play.Rock));
        }

        [Test]
        public void RockIsVaporizedBySpock()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Rock, Play.Spock));
        }

        [Test]
        public void RockBreaksScissors()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.FirstPlayer, game.DoPlay(Play.Rock, Play.Scissors));
        }

        [Test]
        public void ScissorsAreBrokenByRock()
        {
            Game game = new Game();

            Assert.AreEqual(PlayResult.SecondPlayer, game.DoPlay(Play.Scissors, Play.Rock));
        }
    }
}
