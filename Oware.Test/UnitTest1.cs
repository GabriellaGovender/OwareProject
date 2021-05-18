using NUnit.Framework;


namespace Oware.Test
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //ARRANGE
            House h = new House(1,1);
            int intialSeeds = h.GetCount();
            
            //ACT
            h.ResetHouse();
            int testlSeeds = h.GetCount();
            //ASSERT
            Assert.That(testlSeeds, Is.EqualTo(intialSeeds));
        
        }

        [Test]
        public void Test2()
        {
            //ARRANGE
            ScoreHouse sub = new ScoreHouse();
            Player p = new Player("test");
            Seed s = new Seed();
            int result = p.GetScore() + 1;
            //ACT
            p.AddSeedToScoreHouse(s);
            int test = p.GetScore();
            //ASSERT
            Assert.That(test, Is.EqualTo(result));
        
        }
    }
}