namespace Exercise10StrategyTemplate_MealPrep;

public class Meal
{
    public string Name { get; set; } = "Meal";
    public string Base { get; set; } = "Base";
    public string Protein { get; set; } = "Protein";
    public List<string> AddOns { get; } = new();
    public bool Packed { get; set; } = false;
}
