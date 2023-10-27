// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myobj = new {
    Name = "Jiaye Wei",
    Age = 23,
    Address = new {
        Street = "Chemin des Triaudes 4",
        City = "Ecublens"
    }
};
// Console.WriteLine($"{myobj.Name}, {myobj.Address.City}");
// Console.WriteLine($"{myobj}");

// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
// var myobj2 = myobj with {name = "Wei Jiaye"};
// Console.WriteLine($"{myobj2.Name}, {myobj2.Address.City}");
// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myobj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myobj.GetType().GetProperty("Job") != null}");