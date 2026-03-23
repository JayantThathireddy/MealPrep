namespace Exercise10StrategyTemplate_MealPrep;

// Provided Seasoning Strategy : Mediterranean Seasoning
public class MediterraneanSeasoning : ISeasoningStrategy
{
    public string Name { get; }

    public MediterraneanSeasoning()
    {
        Name = "Mediterranean";
    }

    public void Apply(Meal meal)
    {
        meal.AddOns.Add("Olive Oil + Oregano");
        meal.AddOns.Add("Lemon Finish");
    }
}
