using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyShop : Shop
{
    [SerializeField]
    private List<ItemObject> itemsList = new List<ItemObject>(10);

    public override void BuyItem(int iD)
    {
        var item = itemsList.Find(x => x.ID == iD);
        if (item != null)
        {
            if (curPlayer.Money >= item.Price)
            {
                curPlayer.IncreaseMoney(-item.Price);
                curPlayer.AddItemToInventory(item);
            }
        }
    }

    public override void CreateShopList()
    {
        if (shopButtons.Count >= 0)
        {
            for (int i = 0; i < shopButtons.Count; i++)
            {
                Destroy(shopButtons[i].gameObject);
            }
            shopButtons.Clear();
        }

        for (int i = 0; i < itemsList.Count; i++)
        {
            ShopButton curBut = Instantiate(shopButtonPrefab, shopParent);
            curBut.Init(this, itemsList[i],buttonName);
            shopButtons.Add(curBut);
        }
    }
}
