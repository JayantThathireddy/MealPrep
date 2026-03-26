namespace Exercise10StrategyTemplate_MealPrep;

public class AsianStyleSeasoning: ISeasoningStrategy
{    
    public string Name { get; }

    public AsianStyleSeasoning()
    {
        Name = "Asian";
    }

    public void Apply(Meal meal)
    {
        meal.AddOns.Add("Ginger-Soy");
        meal.AddOns.Add("Sesame");
    }
    
}
