using System;

namespace Inventory
{
    [Flags]
    public enum InventoryItemFlags
    {
        NONE = 0,
        EQUPPABLE = 1,
        EFFECTIBLE = 2
    }
}