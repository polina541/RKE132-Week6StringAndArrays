string[] drinks = { "tea", "coffee", "lemonade", "water", "beer" };

Random rnd = new Random();
int randomIndex = rnd.Next(0, drinks.Length);

Console.WriteLine($"Stay hydrated with {drinks[randomIndex]}");
