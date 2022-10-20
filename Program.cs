/*Caroline Hana
10-20-2022
Restaurant Picker - chooses random place to eat
*/

Console.Clear();
Random rnd = new Random();
string? answer;



string[] fastfood = { "McDonalds", "Chick-Fil-A", "Taco Bell", "Wendy's", "Burger King", "Subway", "Domino's", "Chipotle", "Sonic", "Panera Bread" };
string[] restaurant = { "Olive Garden", "The Cheesecake Factory", "Texas Roadhouse", "P.F. Chang's China Bistro", "Red Lobster", "Outback Steakhouse", "Buffalo Wild Wings", "Red Robin", "Denny's", "Chili's" };
string[] dessert = { "Baskin-Robbins", "Dairy Queen", "Kona Ice", "Cold Stone Creamery", "Ben & Jerry's", "Rita's Italian Ice", "Menchie's Frozen Yogurt", "The Häagen-Dazs Shoppe", "Crumbl Cookies", "Krispy Kreme" };

int fastfoodIndex = rnd.Next(fastfood.Length);
int restaurantIndex = rnd.Next(restaurant.Length);
int dessertIndex = rnd.Next(dessert.Length);

string? playAgain = "yes";
while (playAgain == "yes")
{
    Console.WriteLine("Welcome to restaurant picker");
    Console.WriteLine("Choose one of the following FastFood, Restaurant, or Dessert.");

    bool invalidRes = true;

    while (invalidRes)
    {
        answer = Console.ReadLine().ToLower();

        invalidRes = false;

        if (answer == "fastfood")
        {
            Console.WriteLine("Fast Food place choosen: {0} ", fastfood[fastfoodIndex]);
        }
        else if (answer == "restaurant")
        {
            Console.WriteLine("Restaurant place choosen: {0}", restaurant[restaurantIndex]);
        }
        else if (answer == "dessert")
        {
            Console.WriteLine("Dessert place choosen: {0} ", dessert[dessertIndex]);

        }
        else
        {
            Console.WriteLine("Invalid Response.");
            Console.WriteLine("Please enter FastFood, Restaurant, or Dessert.");
            invalidRes = true;
        }

    }

        string? input = "";
        while (input != "yes" && input != "no")
        {
            Console.WriteLine("Would you like to play again? (yes or no)");
            input = Console.ReadLine();
            input = input.ToLower();
            if (input == "yes")
            {
                playAgain = input;
            }
            else if (input == "no")
            {
                playAgain = input;
            }
            else
            {
                Console.WriteLine("Invalid Answer");
            }

        }
    

}


