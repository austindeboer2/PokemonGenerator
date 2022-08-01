namespace Test2
{
    public class Tests
    {
        PokemonGenerator pG;
        Random r;
        int countHP;
        int countAttack;
        int countDefense;
        int countSPA;
        int countSPD;
        int countSpeed;
        [SetUp]
        public void Setup()
        {
            pG = new PokemonGenerator();
            r = new Random();
            countHP = 0;
            countAttack = 0;
            countDefense = 0;
            countSPA = 0;
            countSPD = 0;
            countSpeed = 0;
        }

        [Test]
        public void Test1()
        {
            bool passed = true;
            for (int i = 0; i < 1000; i++)
            {
                

                pG.GenerateStats();
                if (pG.hP == 27) countHP++;
                if (pG.attack == 15) countAttack++;
                if (pG.defense == 13) countDefense++;
                if (pG.specialAttack == 17) countSPA++;
                if (pG.specialDefense == 15) countSPD++;
                if (pG.speed == 18) countSpeed++;
            }
            if (countHP < 200 || countHP > 300) passed = false;
            if (countAttack < 200 || countAttack > 300) passed = false;
            if (countDefense < 200 || countDefense > 300) passed = false;
            if (countSPA < 200 || countSPA > 300) passed = false;
            if (countSPD < 200 || countSPD > 300) passed = false;
            if (countSpeed < 200 || countSpeed > 300) passed = false;

            if (passed) Assert.Pass();
            else
            {
                Assert.Fail("The probability has fallen out of range of what it should be for these stats.");
            }
        }
    }
}