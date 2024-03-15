using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinChallenge
{
    internal class Animals
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public bool Carnivore { get; set; }

        public Animals(string name, int size, bool carnivore)
        {
            Name = name;
            Size = size;
            Carnivore = carnivore;
        }

        public override string ToString()
        {
            return $"{Name} - {Size} - {Carnivore}";
        }

        

    }
}
