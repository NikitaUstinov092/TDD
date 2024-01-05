using System.Collections.Generic;
using System.Linq;
using Inventory;

namespace Crafting.Test.Model
{
    public sealed class TestInventory : IInventory
    {
        private List<string> _items;
        
        public TestInventory(params string[] items)
        {
            _items = new List<string>(items);
        }

        public void Setup(params string[] items)
        {
            _items = new List<string>(items);
        }

        public int GetCount(string item)
        {
            return _items.Count(it => it == item);
        }

        public void Add(string item)
        {
            _items.Add(item);
        }

        public void RemoveAll(string item, int count)
        {
            for (var i = 0; i < count; i++)
            {
                _items.Remove(item);
            }
        }
    }
}
