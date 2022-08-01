namespace Test3
{
    public class Tests
    {
        PokemonGenerator pG;
        Random r;
        [SetUp]
        public void Setup()
        {
            pG = new PokemonGenerator();
            r = new Random();
        }

        [Test]
        public void Test1()
        {
            bool passed = true;
            int countDual = 0;
            for (int i = 0; i < 1000; i++)
            {
                if(pG.GenType().Contains("&")) countDual++;
            }
            if (countDual > 150 || countDual < 50) passed = false;
            if (passed) Assert.Pass("Count: " + countDual);
            else Assert.Fail("An output in your GenerateStats() method has a value that is outside of its acceptable range.");
        }
    }
}