using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryIcon : MonoBehaviour
{
    [SerializeField]
    private TMP_Text buttonText;
    [SerializeField]
    private Image iconImage;

    public void Init(ItemObject item, string nameButton)
    {
        buttonText.text = nameButton + " " + item.Price + " $";
        iconImage.sprite = item.Sprite;
    }
}
