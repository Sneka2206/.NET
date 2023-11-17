using System;

class Students
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Year { get; set; }
    public Students(string name, int age, int year)
    {
        Name = name;
        Age = age;
        Year = year;
    }

    static void Main(string[] args)
    {

        Students student1 = new Students("Sneha", 21, 2023);
        Students student2 = new Students("Sri", 23, 2021);

       
        Console.WriteLine("Student 1 - Name: " + student1.Name + ", Age: " + student1.Age + ", Year: " + student1.Year);
        Console.WriteLine("Student 2 - Name: " + student2.Name + ", Age: " + student2.Age + ", Year: " + student2.Year);
    }
}
