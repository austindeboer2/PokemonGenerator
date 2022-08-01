namespace Test1
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
            for (int i = 0; i < 1000; i++)
            {
                pG.GenerateStats();
                if (pG.hP >= 31 || pG.hP < 27) passed = false;
                if (pG.attack >= 19 || pG.attack < 15) passed = false;
                if (pG.defense >= 17 || pG.defense < 13) passed = false;
                if (pG.specialAttack >= 21 || pG.specialAttack < 17) passed = false;
                if (pG.specialDefense >= 19 || pG.specialDefense < 15) passed = false;
                if (pG.speed >= 22 || pG.speed < 18) passed = false;
                if (pG.total >= 124 || pG.total < 105) passed = false;

            }
            if (passed) Assert.Pass();
            else Assert.Fail("An output in your GenerateStats() method has a value that is outside of its acceptable range.");
        }
    }
}