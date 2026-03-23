namespace Exercise10StrategyTemplate_MealPrep;

public interface ISeasoningStrategy
{
    string Name { get; }
    void Apply(Meal meal);
}