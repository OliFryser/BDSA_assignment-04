foreach(var ingredient in Solid.GetIngredients(Drink.RumNCoke)) 
{
    Console.WriteLine(ingredient);
}

foreach(var ingredient in Solid.GetIngredientsRefactor(Drink.GinNTonic)) 
{
    Console.WriteLine(ingredient);
}
LSP.MakeAnimalSpeak(new Dog());