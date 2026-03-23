namespace Exercise10StrategyTemplate_MealPrep;

// Provided Template: Sheet Pan Dinner
public class SheetPanMealPrep : MealPrepTemplate
{
    public SheetPanMealPrep(ISeasoningStrategy seasoningStrategy) 
        : base(seasoningStrategy)
    {
    }

    protected override void Setup(Meal meal)
    {
        meal.Name = "Sheet Pan Dinner";
    }

    protected override void ChooseBaseAndProtein(Meal meal)
    {
        meal.Base = "Roasted Veg Mix";
        meal.Protein = "Chicken Thighs";
    }

    protected override void Cook(Meal meal)
    {
        if (!meal.Protein.Contains("Roasted"))
        {
            meal.Protein = $"{meal.Protein} (Roasted)";
        }

        meal.AddOns.Add("Crisp Edges");
    }
}

