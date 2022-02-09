using System;
using System.Collections.Generic;

namespace Google
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {

                string[] inputTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!people.ContainsKey(inputTokens[0]))
                {
                    people[inputTokens[0]] = new Person(inputTokens[0]);
                }

                if (inputTokens[1] == "company")
                {
                    string personName = inputTokens[0];
                    string companyName = inputTokens[2];
                    string companyDepartment = inputTokens[3];
                    decimal salary = decimal.Parse(inputTokens[4]);
                    Company company = new Company(companyName, companyDepartment, salary);
                    people[personName].Company = company;
                }
                else if (inputTokens[1] == "pokemon")
                {
                    string pokemonName = inputTokens[2];
                    string pokemonType = inputTokens[3];
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                    people[inputTokens[0]].Pokemons.Add(pokemon);
                }
                else if (inputTokens[1] == "parents")
                {
                    string parentsName = inputTokens[2];
                    string birthDay = inputTokens[3];
                    Parents parent = new Parents()
                    {
                        ParentName = parentsName,
                        ParentBirthday = birthDay
                    };
                    people[inputTokens[0]].Parents.Add(parent);
                }
                else if (inputTokens[1] == "children")
                {
                    string childName = inputTokens[2];
                    string childBirthday = inputTokens[3];
                    Children child = new Children()
                    {
                        ChildrenName = childName,
                        ChildrenBirthDay = childBirthday
                    };
                    people[inputTokens[0]].Children.Add(child);
                }
                else if (inputTokens[1] == "car")
                {
                    string carModel = inputTokens[2];
                    string carSpeed= inputTokens[3];
                    Car car = new Car()
                    {
                        CarModel = carModel,
                        CarSpeed = carSpeed
                    };
                    people[inputTokens[0]].Car = car;
                }
                input = Console.ReadLine(); 
            }
            string nameToSearch = Console.ReadLine();

            
            foreach (var item in people)
            {
                if (item.Key == nameToSearch)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine("Company:");
                    if (item.Value.Company != null)
                    {
                        Console.WriteLine($"{item.Value.Company.CompanyName} {item.Value.Company.Department} {item.Value.Company.Salary:F2}");
                    }
                    
                    Console.WriteLine("Car:");
                    if (item.Value.Car != null)
                    {
                        Console.WriteLine($"{item.Value.Car.CarModel} {item.Value.Car.CarSpeed}");
                    }
                    
                    Console.WriteLine("Pokemon:");
                    if (item.Value.Pokemons.Count > 0)
                    {
                        foreach (var pokemon in item.Value.Pokemons)
                        {
                            Console.WriteLine($"{pokemon.PokemonName} {pokemon.PokemonType}" );
                        }
                    }
                    Console.WriteLine("Parents:");
                    if (item.Value.Parents.Count > 0)
                    {
                        foreach (var parent in item.Value.Parents)
                        {
                            Console.WriteLine($"{parent.ParentName} {parent.ParentBirthday}");
                        }
                    }
                    Console.WriteLine("Children:");
                    if (item.Value.Children.Count > 0)
                    {
                        foreach (var children in item.Value.Children)
                        {
                            Console.WriteLine($"{children.ChildrenName} {children.ChildrenBirthDay}");
                        }
                    }
                }
            }
            
        }
    }
}
