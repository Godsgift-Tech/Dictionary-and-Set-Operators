using Dictionary_SetOperators;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{


    public static void Main(string[] args)

    {
        // Created a dictionary to store ten words and their manings
        Dictionary<string, Wordlist> wordDictionary = new Dictionary<string, Wordlist>();

        // Created an instance of Wordlist class and store them in the dictionary
        wordDictionary["Aberation"] = new Wordlist("Aberration", "A departure from the norm or original");
        wordDictionary["Capricous"] = new Wordlist("Capricous", "Being given to sudden changes in mood or behaviour ");
        wordDictionary["Ineffable"] = new Wordlist("Ineffable", "Too great or extreme to be expressed in words");
        wordDictionary["Sycophat"] = new Wordlist("Sycophant", "A person who acts obsequiously towards someone important in order to gain advantage");
        wordDictionary["Pernicious"] = new Wordlist("Pernicious", "Having a harmful effect, especially in a gradual or subtle way");
        wordDictionary["Ephemeral"] = new Wordlist("Ephemeral", "Lasting for a very short time");
        wordDictionary["Garrulous"] = new Wordlist("Garrulous", "Excessively talkative, especially on trivial matters");
        wordDictionary["Feeble"] = new Wordlist("Feeble", "Markedly lacking in strenght");
        wordDictionary["Zenith"] = new Wordlist("Zenith", "The highest point reached in the heavens by a celestial body");
        wordDictionary["Voracious"] = new Wordlist("Voracious", "Having a huge appetite");

        Console.WriteLine("Firt assignment=> Ten new words and meaning I have for you are");

        Console.WriteLine("***********************************************************************************************************************");
        //Printing out ten new words and meaning using foreach
        foreach (var neword in wordDictionary)
        {
            Console.WriteLine($"{neword.Value.Word}=>: {neword.Value.Meaning}");

        }

        Console.WriteLine("***********************************************************************************************************************");

        Console.WriteLine("Second assignment=> Carrying out SetOperations on array of strings");

        Console.WriteLine("***********************************************************************************************************************");

        // Create an instance of the FoodClasses
        FoodClasses checkFood = new FoodClasses();

        // Calls out for the SetOperator Method
        checkFood.SetOperations();

        Console.ReadKey();

    }
}
