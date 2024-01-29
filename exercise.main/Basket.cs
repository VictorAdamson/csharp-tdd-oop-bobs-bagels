using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private int _capacity = 6;
        private List<Item> _contents = new List<Item>();
        public List<Item> Contents { get { return _contents; } }
        public Basket()
        {

        }
        public Item addItem(Item item)
        {
            if (Contents.Count < _capacity)
            {
                Contents.Add(item);
            }
            Console.WriteLine("Your basket is already full.");
            return item;
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
