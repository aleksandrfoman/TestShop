using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellShop : Shop
{
    private List<ItemObject> itemsList = new List<ItemObject>(10);

    public override void BuyItem(int id)
    {
        var item = itemsList.Find(x => x.ID == id);
        if (item != null)
        {
            curPlayer.IncreaseMoney(item.Price);
            curPlayer.RemoveItemInInventory(id);
            CreateShopList();
        }
    }

    public override void CreateShopList()
    {
        itemsList = curPlayer.GetItemList();

        if (shopButtons.Count >= 0)
        {
            for (int i = 0; i < shopButtons.Count; i++)
            {
                Destroy(shopButtons[i].gameObject);
            }
            shopButtons.Clear();
        }

        if (itemsList.Count != 0)
        {
            for (int i = 0; i < itemsList.Count; i++)
            {
                ShopButton curBut = Instantiate(shopButtonPrefab, shopParent);
                curBut.Init(this, itemsList[i],buttonName);
                shopButtons.Add(curBut);
            }
        }
    }
}
