using UnityEngine;
using UnityEngine.Serialization;

namespace Inventory
{
    [CreateAssetMenu(
        fileName = "InventoryItemConfig",
        menuName = "Inventory/New InventoryItemConfig"
    )]
    public sealed class InventoryItemConfig : ScriptableObject
    {
        [FormerlySerializedAs("item")] [SerializeField]
        public InventoryItem Item;
    }
}