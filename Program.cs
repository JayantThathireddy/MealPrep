namespace Exercise10StrategyTemplate_MealPrep;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Minimal Meal Prep Planner");
        Console.Write("Choose template (SHEET/STIRFRY): ");
        string? t = Console.ReadLine()?.Trim().ToUpperInvariant();

        Console.Write("Choose seasoning (MED/ASIAN/BBQ): ");
        string? s = Console.ReadLine()?.Trim().ToUpperInvariant();

        // TODO: Select the correct seasoning STRATEGY.
        ISeasoningStrategy seasoning = new MediterraneanSeasoning(); // default seasoning
        switch (s)
        {
            case "MED":
                break;
            case "BBQ":
                seasoning = new BbqRubSeasoning();
                break;
            case "ASIAN":
                seasoning = new AsianStyleSeasoning();
                break;
        }
        
        // TODO: Select the correct meal prep TEMPLATE.
        MealPrepTemplate template = new SheetPanMealPrep(seasoning); // default template
        switch (t)
        {
            case "SHEET":
                break;
            case "STIRFRY":
                template = new StirFryBowlMealPrep(seasoning);
                break;
        }

        // TODO: Prepare the template using the seasoning strategy.

        Meal meal = template.Prepare();

        // Show actual mutated STATE
        Console.WriteLine("\n=== Meal Summary ===");
        Console.WriteLine($"Name:    {meal.Name}");
        Console.WriteLine($"Base:    {meal.Base}");
        Console.WriteLine($"Protein: {meal.Protein}");
        Console.WriteLine($"AddOns:  {string.Join(", ", meal.AddOns)}");
        Console.WriteLine($"Packed:  {(meal.Packed ? "Yes" : "No")}");
    }
}
