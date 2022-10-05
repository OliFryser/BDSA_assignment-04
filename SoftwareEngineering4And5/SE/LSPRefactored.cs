public class LSPRefactored {
    // Liskov Substitution Principle - refactored
    public static void MakeAnimalSpeakRefactor(AnimalRefactor animal) 
    {
        animal.Speak();
    }
}
public abstract class AnimalRefactor 
{
    public abstract void Speak();
}
public class BirdRefactor : AnimalRefactor
{
    public override void Speak() => Console.WriteLine("Chirp chirp");
}
public class DogRefactor : AnimalRefactor
{
    public override void Speak() => Console.WriteLine("Bark Bark");
}