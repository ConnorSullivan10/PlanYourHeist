using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Enter a team member's name");
            var name = Console.ReadLine();
            TeamMember newbie = new TeamMember(name);

            Console.WriteLine("Enter the team member's skill level as an integer");
            var skillInput = Console.ReadLine();
            //if (!int.TryParse(skillInput, out _))
            //{
            //    Console.WriteLine("That's not a number. Please try again");

            //}
            //else
            //{
            //    newbie.SkillLevel = Convert.ToInt32(skillInput);
            //}
            newbie.SkillLevel = Convert.ToInt32(skillInput);

            Console.WriteLine("Finally, enter the team member's courage factor as any decimal between 0 and 2");
            var courage = decimal.Parse(Console.ReadLine());
            if (courage < 2 && courage > 0)
            {
                newbie.CourageFactor = courage;
                Console.WriteLine("Here is your new team member's info");
                Console.WriteLine($"Name: {newbie.Name}");
                Console.WriteLine($"Skill Level: {newbie.SkillLevel}");
                Console.WriteLine($"Courage Factor: {newbie.CourageFactor}");
            }
            else
            {
                Console.WriteLine("Woah woah woah, I said between 0 and 2 please. Please start again.");
            }




        }
    }
}
