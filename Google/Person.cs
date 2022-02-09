using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Person
    {
        public string Name { get; set; }
        public Company Company{ get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public List<Parents> Parents{ get; set; }
        public List<Children> Children { get; set; }
        public Car Car { get; set; }

        public Person(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parents>();
            this.Children = new List<Children>();
        }
    }
}
