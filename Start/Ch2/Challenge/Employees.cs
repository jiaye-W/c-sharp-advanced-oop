// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public class Employee {
    public Employee() {}

    // YOUR CODE GOES HERE
    private readonly int _id;

    public required string? FullName{
        get; set;
    }

    public required string? Department{
        get; set;
    }

    public required int ID{
        get => _id; 
        init => _id = value;
    }

    public virtual void AdjustPay(decimal percentage){}

    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

// DEFINE OTHER CLASSES HERE
class HourlyEmployee : Employee{
    public decimal PayRate{
        get; set;
    }

    public override void AdjustPay(decimal percentage)
    {
        PayRate += PayRate * percentage;
    }
}

class SalariedEmployee : Employee{
    public decimal Salary{
        get; set;
    }

    public override void AdjustPay(decimal percentage)
    {
        Salary += Salary * percentage;
    }
}