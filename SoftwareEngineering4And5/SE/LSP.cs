public class LSP {
    // Liskov Substitution Principle
    public static void MakeAnimalSpeak(Animal animal) 
    {
        if(animal.GetType() == typeof(Bird)) 
            (animal as Bird).Chirp();
        else if(animal.GetType() == typeof(Dog))
            (animal as Dog).Bark();
    }
}
public abstract class Animal 
{
}
public class Bird : Animal
{
    public void Chirp() => Console.WriteLine("Chirp chirp");
}
public class Dog : Animal
{
    public void Bark() => Console.WriteLine("Bark Bark");
}