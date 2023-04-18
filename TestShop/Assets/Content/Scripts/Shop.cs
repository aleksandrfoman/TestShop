using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    protected Trigger trigger;
    protected Player curPlayer;
    [SerializeField]
    protected GameObject shopUi;
    [SerializeField]
    protected Transform shopParent;
    [SerializeField]
    protected ShopButton shopButtonPrefab;
    protected List<ShopButton> shopButtons = new List<ShopButton>(10);
    [SerializeField]
    protected string buttonName;

    public virtual void BuyItem(int iD)
    {
        Debug.Log("BuyItem");
    }

    public virtual void CreateShopList()
    {
        Debug.Log("Create");
    }


    private void Awake()
    {
        trigger.OnEnterTrigger.AddListener(ActivateShop);
        trigger.OnExitTrigger.AddListener(DeactivateShop);
    }

    private void ActivateShop(Player player)
    {
        curPlayer = player;
        CreateShopList();
        shopUi.gameObject.SetActive(true);
    }

    private void DeactivateShop(Player player)
    {
        curPlayer = null;
        shopUi.gameObject.SetActive(false);
    }
}
