using System;
using System.Collections.Generic;

class Inventory
{
    Dictionary<int, Item> StoredItems = new Dictionary<int, Item>();

    public Inventory()
    {

    }

    public void AddItem(Item item) { StoredItems.Add(StoredItems.Count +1, item); }

    public void RemoveItem (int index) { StoredItems.Remove(index); }

    public void SwitchItems (int  index1, int index2)
    {
        Item item1 = StoredItems[index1];

        StoredItems[index1] = StoredItems[index2];
        StoredItems[index2] = item1;
    }

    override public string ToString()
    {
        string StringInventory = "";

        foreach (KeyValuePair<int, Item> entry in StoredItems)
        {
            StringInventory += entry.Value.ToString() + " ";
        }

        if (StringInventory == "")
            StringInventory = "Empty";
        return StringInventory;
    }
}