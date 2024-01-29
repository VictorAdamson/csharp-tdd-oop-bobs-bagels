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
            Contents.Add(item);
            return item;
        }
        public Item removeItem(Item item)
        {
            return item;
        }
        public int changeBasketSize(int newSize)
        {
            return newSize;
        }
    }
}
