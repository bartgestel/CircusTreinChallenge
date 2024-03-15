using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinChallenge
{
    internal class Cart
    {
        public List<Animals> Animals { get; set; }

        private int cartCapacity = 10;

        public int cartSize = 0;

        public Cart()
        {
            Animals = new List<Animals>();
        }

        public void AddAnimal(Animals animal)
        {
            Animals.Add(animal);
            cartSize += animal.Size;
        }

        public bool CanAddAnimal(Animals animal)
        {
            if (cartSize + animal.Size <= cartCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool CanEat(Animals animal)
        {
            foreach (Animals a in Animals)
            {
                if (a.Carnivore && a.Size >= animal.Size)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
