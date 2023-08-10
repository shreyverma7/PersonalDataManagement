namespace PersonalDataManagement;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Data management system: ");
        List<Person> persons = new List<Person>();
        persons.Add(new Person()
        {
            SSN = 1,
            Name = "a",
            Address = "a",
            Age = 15,
        });
        persons.Add(new Person()
        {
            SSN = 2,
            Name = "b",
            Address = "b",
            Age = 10,
        });
        persons.Add(new Person()
        {
            SSN = 3,
            Name = "c",
            Address = "c",
            Age = 20,
        });
        persons.Add(new Person()
        {
            SSN = 4,
            Name = "d",
            Address = "d",
            Age = 25,
        });
        persons.Add(new Person()
        {
            SSN = 5,
            Name = "e",
            Address = "e",
            Age = 22,
        });
        persons.Add(new Person()
        {
            SSN = 6,
            Name = "f",
            Address = "f",
            Age = 24,
        });
        persons.Add(new Person()
        {
            SSN = 7,
            Name = "e",
            Address = "e",
            Age = 26,
        });
        persons.Add(new Person()
        {
            SSN = 8,
            Name = "f",
            Address = "f",
            Age = 12,
        });
        persons.Add(new Person()
        {
            SSN = 9,
            Name = "g",
            Address = "g",
            Age = 14,
        });
        persons.Add(new Person()
        {
            SSN = 10,
            Name = "h",
            Address = "h",
            Age = 27,
        });

    }
}