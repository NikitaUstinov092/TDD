
    namespace Crafting.Test.Model
    {
        public readonly struct ItemIngredient
        {
            public readonly string item;
            public readonly int count;

            public ItemIngredient(string item, int count)
            {
                this.count = count;
                this.item = item;
            }
        }
    }
