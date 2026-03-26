namespace Exercise10StrategyTemplate_MealPrep;

public class BbqRubSeasoning: ISeasoningStrategy
{    
    public string Name { get; }

    public BbqRubSeasoning()
    {
        Name = "Bbq";
    }

    public void Apply(Meal meal)
    {
        meal.AddOns.Add("BBQ Dry Rub");
        meal.AddOns.Add("Smoked Paprika");
    }
    
}