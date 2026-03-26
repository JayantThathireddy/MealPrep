namespace Exercise10StrategyTemplate_MealPrep;

public class StirFryBowlMealPrep : MealPrepTemplate
{
    public StirFryBowlMealPrep(ISeasoningStrategy seasoningStrategy) 
        : base(seasoningStrategy)
    {
    }

    protected override void Setup(Meal meal)
    {
        meal.Name = "Stir-Fry Bowl";
    }

    protected override void ChooseBaseAndProtein(Meal meal)
    {
        meal.Base = "Rice Noodles";
        meal.Protein = "Tofu Cubes";
    }

    protected override void Cook(Meal meal)
    {
        if (!meal.Protein.Contains("Wok-Seared"))
        {
            meal.Protein = $"{meal.Protein} (Wok-Seared)";
        }

        meal.AddOns.Add("Wok Char");
    }
}