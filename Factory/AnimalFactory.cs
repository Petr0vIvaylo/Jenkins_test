using System;
using System.Collections.Generic;
using System.Text;
using AnimalFarm.Animals;

namespace AnimalFarm.Factory
{
   public class AnimalFactory
    {
        public Animal CreateAnimal(string type, string name, string gender, int age)
        {
            type = type.ToLower();

            switch (type)
            {
                case "dog": return new Dog(name, age, gender);
                case "cat": return new Cat(name, age, gender);
                case "frog": return new Frog(name, age, gender);
                case "tomcat": return new Tomcat(name, age);
                case "kitten": return new Kitten(name, age);
                default:
                    throw new Exception("Invalid input!");
                    
            }
        }
    }
}
