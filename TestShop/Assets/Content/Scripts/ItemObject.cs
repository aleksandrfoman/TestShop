using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class ItemObject : ScriptableObject
{
    [SerializeField]
    private string name;
    private string Name => name;

    [SerializeField]
    private Sprite sprite;
    public Sprite Sprite => sprite;

    [SerializeField]
    private int id;
    public int ID => id;

    [SerializeField]
    private int price;
    public int Price => price;
}
