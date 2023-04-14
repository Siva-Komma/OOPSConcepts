using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welome to OOPs Concepts");
            Console.WriteLine("1.Class and Object\n2.Inheritance\n3.Polymorphism overriding Overloading\n4.Encapsulation\n5.Abstraction\n6.Types of Variables\n7.TypesofMethods");
            Console.WriteLine("Choose Your Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    //Class and Object Concept
                    PrintNumbers num = new PrintNumbers();
                    num.Numbers();
                    break;
                case 2:
                    //Inheritance
                    VehicleDetails vd = new VehicleDetails();
                    vd.Details();
                    break;
                case 3:
                    //Polymorphism - Overriding
                    Console.WriteLine("Overriding");
                    Animal animal = new Animal();
                    Pig pig = new Pig();    
                    Dog dog = new Dog();
                    animal.AnimalSound();
                    pig.AnimalSound();
                    dog.AnimalSound();
                    Console.WriteLine("\nOverloading");
                    // OverLoading
                    Calculation.Sum(10, 20);
                    Calculation.Sum(10.5f, 20);
                    Calculation.Sum("Siva", 30, 40);
                    break;
                case 4:
                    //Encapsulation
                    Encapsulation encapsulation = new Encapsulation();
                    encapsulation.Name = "Siva";
                    encapsulation.Age = 22;
                    Console.WriteLine("Name of the Student: " + encapsulation.Name);
                    Console.WriteLine("Age of the Student: " + encapsulation.Age);
                    break;
                case 5:
                    //Abstraction
                    VehiclesModel vehicles = new VehiclesModel();
                    vehicles.VehicleType();
                    vehicles.VehiclesDetails();
                    break;
                case 6:
                    //Types of Variables
                    TypesofVariables.Variables();
                    break;
                case 7:
                    //TypesofMethods
                    //Static Method Parameterised Method
                    TypesOfMethods methods = new TypesOfMethods();
                    methods.StdDetail();
                    TypesOfMethods.StdDetails(18,100);
                    break;
            }
            Console.ReadLine();
        }
    }
}
