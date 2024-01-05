
    namespace Crafting.Test.Model
    {
        public readonly struct ItemReceipt
        {
            public readonly string CraftItem;
            public readonly ItemIngredient[] Ingredients;

            public ItemReceipt(string craftItem, params ItemIngredient[] ingredients)
            {
                CraftItem = craftItem;
                Ingredients = ingredients;
            }
        }
    }
