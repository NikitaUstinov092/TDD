using Sirenix.OdinInspector;
using UnityEngine;

namespace Inventory
{
    public sealed class InventoryContext : MonoBehaviour
    {
        [ShowInInspector]
        public readonly ListInventory Inventory = new();
        
        [Button]
        public void AddItem(InventoryItemConfig config)
        {
            var prefab = config.Item;
            var inventoryItem = prefab.Clone();
            Inventory.AddItem(inventoryItem);
        }
        
        [Button]
        public void RemoveItem(InventoryItemConfig config)
        {
            Inventory.RemoveItem(config.Item.Name);
        }

        public ListInventory GetInventory()
        {
            return Inventory;
        }
    }
    
}