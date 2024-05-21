using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_SetOperators
{
    public class FoodClasses
    {/// <summary>
     ///  Declared two properties: AllFood and Carbohydrate, both are arrays of strings
     /// </summary>
        public string[] AllFood { get; set; }
        public string[] Carbohydrates { get; set; }


        public FoodClasses()

        {
            // This constructor FoodClass is just to initialize these arrays with some examp,les of food        
            AllFood = new string[]
            {
        "Beans", "Yam", "Orange", "Garri", "Egg", "Fish Pie", "Rice", "Milk", "Sugar", "Carrot",  "Garri","Plantain",
            };
            Carbohydrates = new string[]
            {
            "Yam", "Spagetti", "Plantain", "Bread", "Rice", "Garri", "Wheat", "Sugar", "Spagetti","Bread", "Pasta", "Oats", "Rice"
            };

        }
        /// <summary>
        /// Using LINQ methods to perform set operators on these arrays
        /// </summary>
        public void SetOperations()

        {   // Distinct removes duplicated food from AllFood
            var distinctAllFood = AllFood.Distinct();

            // Distinct removes duplicated Carbohydrates
            var distinctCarbohydrates = Carbohydrates.Distinct();

            // Intersect finds common food between AllFood and Carbohydrates
            var intersection = Carbohydrates.Intersect(AllFood);

            // Except finds the food that are in AllFood  but not in Carbohydrates
            var except = AllFood.Except(Carbohydrates);

            // Union combine the arrays of both food but check for duplicated food and removes it
            var union = AllFood.Union(Carbohydrates);
            Console.WriteLine("(DISTINCT)=> Distinct type of food in AllFood are:");
            foreach (var meal in distinctAllFood)
            {
                Console.WriteLine(meal);
            }

            Console.WriteLine("**********************************************************");

            Console.WriteLine("(DISTINCT)=>  Distinct type of food in Carbohydrate are:");
            foreach (var meal in distinctCarbohydrates)
            {
                Console.WriteLine(meal);
            }

            Console.WriteLine("**********************************************************");

            Console.WriteLine("(INTERSECTION)=> The food within the intersection of AllFood and Carbohydrate are: ");
            foreach (var meal in intersection)
            {
                Console.WriteLine(meal);
            }

            Console.WriteLine("**********************************************************");

            Console.WriteLine("(EXCEPT)=> The list of food in AllFood that are not Carbohydrates are:");
            foreach (var meal in except)
            {
                Console.WriteLine(meal);

            }

            Console.WriteLine("**********************************************************");

            Console.WriteLine("(UNION)=> The Union of AllFood and Carbohydrates is:");
            foreach (var meal in union)
            {
                Console.WriteLine(meal);
            }
        }
    }
}

