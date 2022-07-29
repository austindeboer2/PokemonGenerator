//This is a pokemon generator for pokemon of lvl 10.
public class PokemonGenerator
{
    //Creates a random object to use later
    Random random;

    //Creates stat variables
    public int total;
    public int hP;
    public int attack;
    public int defense;
    public int specialAttack;
    public int specialDefense;
    public int speed;

    //creates the string for what type pokemon this is
    string type;

    //Class constructor: instatiates the random variable
    public PokemonGenerator()
    {
        random = new Random();
    }

    //This function runs all the generator functions to give the pokemon all its stats.
    public void GenerateStats()
    {
        hP = GenHP();
        attack = GenAttack();
        defense = GenDefense();
        specialAttack = GenSpAttack();
        specialDefense = GenSpDefense();
        speed = GenSpeed();
        type = GenType();
        total = GenTotal();

        Console.WriteLine(StatsToString());
    }

    //Method writes all the stats into one string
    public string StatsToString() 
    {
        return "Total: " + total + "\n" + "HP: " + hP + "\n" + "Attack: " + attack + "\n" + "Defense: " + defense + "\n" + "Special Attack: " + specialAttack + "\n" + "Special Defense: " + specialDefense + "\n" + "Speed: " + speed + "\n" + "Type: " + type;
    }

    //To Do-Return a number from 27-30
    public int GenHP()
    {
       
    }

    //To Do-Return a number from 15-18
    public int GenAttack()
    {
        
    }

    //To Do-Return a number from 13-16
    public int GenDefense()
    {
        
    }

    //To Do-Return a number from 17-20
    public int GenSpAttack()
    {
        
    }

    //To Do-Return a number from 15-18
    public int GenSpDefense()
    {
        
    }

    //To Do-Return a number from 18-21
    public int GenSpeed()
    {
        
    }

    //Returns all the stats added together (hp, attack, defense, spAttack, spDefense, and speed)
    public int GenTotal()
    {
        
    }

    /*
     * Goal: Return 1 or 2 random pokemon types
     * To Do- Write the function to return 1 type 90% of the time and 2 types 10% of the time. 
     * Note: When returning 2 types make sure to write it in the for ___ & ___. Example: Fire & Grass.
     */
    public string GenType()
    {
        
    }


    //This function returns a random type
    public string NumberToType()
    {
        int type = random.Next(1, 19);
        switch (type)
        {
            case 1:
                return "Normal";
            case 2:
                return "Fire";
            case 3:
                return "Water";
            case 4:
                return "Grass";
            case 5:
                return "Electric";
            case 6:
                return "Ice";
            case 7:
                return "Fighting";
            case 8:
                return "Poison";
            case 9:
                return "Ground";
            case 10:
                return "Flying";
            case 11:
                return "Psychic";
            case 12:
                return "Bug";
            case 13:
                return "Rock";
            case 14:
                return "Ghost";
            case 15:
                return "Dark";
            case 16:
                return "Dragon";
            case 17:
                return "Steel";
            case 18:
                return "Fairy";
            default:
                return "Index Out Of Bounds";
        }
    }

    public static void Main(string[] args)
    {
        PokemonGenerator pg = new PokemonGenerator();
        pg.GenerateStats();
    }
}