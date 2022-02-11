using AnimalFarm.Animals;
using AnimalFarm.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Core
{
    public class Engine
    {
        private AnimalFactory animalFactory;
        private List<Animal> animals;

        public Engine()
        {
            this.animalFactory = new AnimalFactory();
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                try
                {
                    string[] animalInfo = Console.ReadLine().Split(' ');
                    string name = animalInfo[0];
                    int age = int.Parse(animalInfo[1]);
                    string gender = animalInfo[2];

                    Animal animal = animalFactory.CreateAnimal(input, name, gender, age);
                    animals.Add(animal);

                    
                    
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                input = Console.ReadLine();
            }
            Print();
        }

        private void Print()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }
    }
}
