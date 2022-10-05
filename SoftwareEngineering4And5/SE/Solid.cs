public class Solid
{
    // Single Responsibility Principle
    public static int CalculateSquarePlusHalf(int x) => x * x + x / 2;

    // SRP Refactored
    public static int CalculateSquare(int x) => x * x;

    public static int CalculateHalf(int x) => x / 2;

    // Open/Closed Principle
    public static List<Ingredient> GetIngredients(Drink drink)
    {
        switch (drink)
        {
            case Drink.RumNCoke:
                return new List<Ingredient> { Ingredient.Rum, Ingredient.Coke, Ingredient.Ice };
            case Drink.GinNTonic:
                return new List<Ingredient> { Ingredient.Gin, Ingredient.Tonic, Ingredient.Ice };
            case Drink.Margarita:
                return new List<Ingredient> { Ingredient.Tequila, Ingredient.TripleSec, Ingredient.Ice };
            default:
                return new List<Ingredient> { };
        }
    }

    // Open/Closed Principle refactored
    public static IList<Ingredient> GetIngredientsRefactor(Drink drink)
    {
        return DRINKS[drink].Ingredients;
    }

    public interface IDrink
    {
        IList<Ingredient> Ingredients { get; }
    }

    public class RumNCoke : IDrink
    {
        public IList<Ingredient> Ingredients => new List<Ingredient> 
        {
            Ingredient.Rum,
            Ingredient.Coke,
            Ingredient.Ice
        };
    }

    public class Margarita : IDrink
    {
        public IList<Ingredient> Ingredients => new List<Ingredient> 
        {
            Ingredient.Tequila,
            Ingredient.TripleSec,
            Ingredient.Ice
        };
    }

    public class GinNTonic : IDrink
    {
        public IList<Ingredient> Ingredients => new List<Ingredient> 
        {
            Ingredient.Gin,
            Ingredient.Tonic,
            Ingredient.Ice
        };
    }

    
    private static readonly Dictionary<Drink, IDrink> DRINKS = 
        new Dictionary<Drink, IDrink>() 
    {
        [Drink.RumNCoke] = new RumNCoke(),
        [Drink.GinNTonic] = new GinNTonic(),
        [Drink.Margarita] = new Margarita()
    };
}