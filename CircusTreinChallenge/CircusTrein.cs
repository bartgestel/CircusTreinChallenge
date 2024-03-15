using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinChallenge
{
    internal class CircusTrein
    {
        public List<Animals> Animals { get; private set; }

        public List<Cart> Carts { get; set; }

        public CircusTrein()
        {
            Animals = new List<Animals>();
            Carts = new List<Cart>();
        }

        public void AddAnimal(Animals animal)
        {
            Animals.Add(animal);
        }

        public void SortAnimals()
        {
            Carts.Clear();
            Animals.Sort((x, y) => y.Size.CompareTo(x.Size));
            foreach(Animals animal in Animals)
            {
                bool added = false;
                
                    foreach(Cart cart in Carts)
                    {
                        if (cart.CanAddAnimal(animal) && cart.CanEat(animal))
                        {
                            cart.AddAnimal(animal);
                            added = true;
                            break;
                        }
                        cart.AddAnimal(animal);
                    }
                    
                
                if(!added)
                {
                    Cart newCart = new Cart();
                    newCart.AddAnimal(animal);
                    Carts.Add(newCart);
                }
            }
        }
    }
}
