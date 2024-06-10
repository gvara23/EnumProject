using System.Drawing;

namespace EnumProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User("John", "Doe", Ecolors.Red),
                new User("Jane", "Smith", Ecolors.Blue),
                new User("Alice", "Johnson", Ecolors.Green),
                new User("Bob", "Brown", Ecolors.Yellow),
                new User("Carol", "Davis", Ecolors.Red)
            };

            foreach (var user in users)
            {
                Console.WriteLine(user);
                Console.WriteLine();
            }

            Dictionary<Ecolors, int> colorCount = new Dictionary<Ecolors, int>();

            foreach (Ecolors color in Enum.GetValues(typeof(Ecolors)))
            {
                colorCount[color] = 0;
            }

            foreach (var user in users)
            {
                colorCount[user.Color]++;
            }

            foreach (var entry in colorCount)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value} utilisateurs");
            }
        }
    }
}
