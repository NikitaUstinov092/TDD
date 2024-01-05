using System;
using Inventory;

namespace Crafting.Test.Model
{
    public sealed class ItemCrafter
    {
        private readonly IInventory _inventory;

        public ItemCrafter(IInventory inventory)
        {
            _inventory = inventory;
        }

        public bool CanCraft(ItemReceipt receipt)
        {
            foreach (var ingredient in receipt.Ingredients)
            {
                if (_inventory.GetCount(ingredient.item) < ingredient.count)
                {
                    return false;
                }
            }

            return true;
        }

        public void Craft(ItemReceipt receipt) //Receipt
        {
            foreach (var ingredient in receipt.Ingredients)
            {
                if (_inventory.GetCount(ingredient.item) < ingredient.count)
                {
                    throw new Exception($"Not enough item {ingredient.item} {ingredient.count}");
                }
            }

            foreach (var ingredient  in receipt.Ingredients)
            {
                _inventory.RemoveAll(ingredient.item, ingredient.count);
            }

            _inventory.Add(receipt.CraftItem);
        }
    }
}
