using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Inventory
{
    [Serializable]
    public sealed class InventoryItemMetadata
    {
        [FormerlySerializedAs("title")] [SerializeField]
        public string Title;

        [FormerlySerializedAs("description")]
        [TextArea]
        [SerializeField]
        public string Description;

        [FormerlySerializedAs("icon")] [SerializeField]
        public Sprite Icon;
    }
}