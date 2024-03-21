using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Getter method for name
    public string GetName()
    {
        return name;
    }

    // Setter method for name
    public void SetName(string newName)
    {
        name = newName;
    }

    // Getter method for age
    private int GetAge()
    {
        return age;
    }

    // Setter method for age
    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            age = newAge;
        }
        else
        {
            Console.WriteLine("Age cannot be negative.");
        }
    }
}

