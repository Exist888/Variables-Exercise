namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Super Mario";
            int numberOfDays = 31;
            char mushroomsLooksLike = 'o';
            bool hasTeamwork = true;
            double mushroomsPerDay = 12.8;
            decimal numberOfSunnyDays = 23.5m;
            
            Console.WriteLine($"{name} has {numberOfDays} days to gather mushrooms before the weather gets cold.");
            Console.WriteLine($"He prefers a specific type of mushroom that looks like this: {mushroomsLooksLike}.");
            Console.WriteLine($"Thankfully, it is {hasTeamwork} that he gets help from Luigi and Toad.");
            Console.WriteLine($"This way, the team is able to gather {mushroomsPerDay} mushrooms per day.");
            Console.WriteLine($"They also have a nice, sunny month with {numberOfSunnyDays} sunny days,\n" +
                              $"so they have plenty of time to gather enough mushrooms to eat.");
        }
    }
}
