namespace Exercise10StrategyTemplate_MealPrep;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("🍱 Minimal Meal Prep Planner");
        Console.Write("Choose template (SHEET/STIRFRY): ");
        string? t = Console.ReadLine()?.Trim().ToUpperInvariant();

        Console.Write("Choose seasoning (MED/ASIAN/BBQ): ");
        string? s = Console.ReadLine()?.Trim().ToUpperInvariant();

        // TODO: Select the correct seasoning STRATEGY.

        // TODO: Select the correct meal prep TEMPLATE.

        // TODO: Prepare the template using the seasoning strategy.
        // Meal meal = ???

        // Show actual mutated STATE
        Console.WriteLine("\n=== Meal Summary ===");
        Console.WriteLine($"Name:    {meal.Name}");
        Console.WriteLine($"Base:    {meal.Base}");
        Console.WriteLine($"Protein: {meal.Protein}");
        Console.WriteLine($"AddOns:  {string.Join(", ", meal.AddOns)}");
        Console.WriteLine($"Packed:  {(meal.Packed ? "Yes" : "No")}");
    }
}
