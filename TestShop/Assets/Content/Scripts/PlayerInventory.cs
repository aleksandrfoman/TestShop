using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private List<ItemObject> itemsList = new List<ItemObject>(10);
    public List<ItemObject> GetItemList()
    {
        return itemsList;
    }

    public void AddItem(ItemObject itemObject)
    {
        itemsList.Add(itemObject);
    }

    public void RemoveItem(int itemId)
    {
        var item = itemsList.Find(x => x.ID == itemId);
        itemsList.Remove(item);
    }
}
