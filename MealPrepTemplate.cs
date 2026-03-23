namespace Exercise10StrategyTemplate_MealPrep;

// Template Method base: fixed prep flow
public abstract class MealPrepTemplate
{
    private ISeasoningStrategy _seasoningStrategy;

    public MealPrepTemplate(ISeasoningStrategy seasoningStrategy)
    {
        this._seasoningStrategy = seasoningStrategy;
    }
    
    public Meal Prepare()
    {
        Meal meal = new Meal();
        Setup(meal);
        ChooseBaseAndProtein(meal);
        ApplySeasoning(meal); // STRATEGY
        Cook(meal);
        Pack(meal);
        return meal;
    }

    protected abstract void Setup(Meal meal);
    protected abstract void ChooseBaseAndProtein(Meal meal);
    protected abstract void Cook(Meal meal);
    
    protected virtual void ApplySeasoning(Meal meal)
    {
        this._seasoningStrategy.Apply(meal);
    }

    protected virtual void Pack(Meal meal)
    {
        meal.Packed = true;
    }
}
