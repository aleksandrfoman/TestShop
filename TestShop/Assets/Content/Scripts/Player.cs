using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int money;
    public int Money => money;

    [SerializeField]
    private TMP_Text moneyText;

    [SerializeField]
    private PlayerInventory playerInventory;
    [SerializeField]
    private InventoryIcon buttonPrefab;
    private List<InventoryIcon> inventoryIcons = new List<InventoryIcon>(10);
    private List<ItemObject> itemsList = new List<ItemObject>(10);
    [SerializeField]
    protected Transform shopParent;


    private void Start()
    {
        UpdateMoneyText();
    }

    public void IncreaseMoney(int value)
    {
        money += value;
        UpdateMoneyText();
    }

    public void AddItemToInventory(ItemObject item)
    {
        //AddToList
        playerInventory.AddItem(item);
        UpdatePlayerInventory();
    }

    public void RemoveItemInInventory(int id)
    {
        playerInventory.RemoveItem(id);
        UpdatePlayerInventory();
    }

    public List<ItemObject> GetItemList()
    {
        return playerInventory.GetItemList();
    }

    public void UpdatePlayerInventory()
    {
        itemsList = GetItemList();
        if (inventoryIcons.Count >= 0)
        {
            for (int i = 0; i < inventoryIcons.Count; i++)
            {
                Destroy(inventoryIcons[i].gameObject);
            }
            inventoryIcons.Clear();
        }

        if (itemsList.Count != 0)
        {
            for (int i = 0; i < itemsList.Count; i++)
            {
                InventoryIcon curIcon = Instantiate(buttonPrefab, shopParent);
                curIcon.Init(itemsList[i], itemsList[i].name);
                inventoryIcons.Add(curIcon);
            }
        }
    }

    public void UpdateMoneyText()
    {
        moneyText.text = money.ToString() + " $";
    }
}