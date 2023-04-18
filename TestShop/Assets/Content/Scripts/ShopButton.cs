using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    [SerializeField]
    private Button button;
    [SerializeField]
    private TMP_Text buttonText;
    [SerializeField]
    private Image iconImage;
    private Shop shop;
    private ItemObject item;

    public void Init(Shop shop, ItemObject item,string nameButton)
    {
        this.shop = shop;
        this.item = item;
        buttonText.text = nameButton +" "+item.Price+" $";
        iconImage.sprite = item.Sprite;
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(BuyClick);
    }

    private void BuyClick()
    {
        shop.BuyItem(item.ID);
    }
}
