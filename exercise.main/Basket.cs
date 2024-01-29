using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private Inventory _inventory = new Inventory();
        private int _capacity = 6;
        private List<Item> _contents = new List<Item>();
        private Receipt _receipt;
        public Receipt Receipt { get { return _receipt; } }
        public List<Item> Contents { get { return _contents; } }
        public Basket()
        {

        }
        public Item addItem(string SKU)
        {
            if (Contents.Count < _capacity)
            {
                if (_inventory.inInventory(SKU))
                {
                    foreach (var product in _inventory.inventory)
                    {
                        if (product.SKU == SKU)
                        {
                            Contents.Add(product);
                            return product;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("We do not serve that product.");
                }
            }
            else
            {
                Console.WriteLine("Your basket is already full.");
            }
            return null;
        }
        public Item removeItem(Item item)
        {
            if (Contents.Contains(item))
            {
                Contents.Remove(item);
            }
            else
            {
                Console.WriteLine($"Your basket does not contain {item}.");
            }
            return item;
        }
        public int changeBasketSize(int newSize)
        {
            _capacity = newSize;
            return _capacity;
        }
    }
}
