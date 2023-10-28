// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog {Name = "Fido", Age = 4, IsTrained = true};
Cat cat = new Cat {Name = "Mr.Meowington", Age = 7, IsDeclawed = false};
// Console.WriteLine($"Dog: {dog.Name}, {dog.Age}");
// Console.WriteLine($"Cat: {cat.Name}, {cat.Age}");

// TODO: Initializers can be used on anonymous types
var pet = new {Name = "Charlie", Age = 5};
// Console.WriteLine($"Pet: {pet.Name}, {pet.Age}");

// TODO: Collections can also be initialized this way
int[] numbers = new int[] {1,2,3,4,5,6};
// Console.WriteLine($"{numbers.Length}");

// TODO: Initialize a collection with a set of objects
PetOwner owner = new PetOwner{
    Name = "Jiaye Wei", 
    Pets = new List<Pet>{
        new Dog {Name = "Junebug", Age = 4},
        new Cat {Name = "whisker", Age = 3},
        new Dog {Name = "Max", Age = 10}
    }
};

Console.WriteLine($"{owner.Name}'s pets: ");
foreach (Pet p in owner.Pets)
{
    Console.WriteLine($"{p.Name}");
}