using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "ScriptableObjects/NewItem", order = 0)]
public class Item : ScriptableObject
{
    public string itemName;
    public string description;
    public int price;
    public Sprite image;
    public ItemType itemType;
    public bool stackable;

    public enum ItemType
    {
        Hat,
        Shirt,
        Pants,
        Shoes,
        Assessory,
        Consumable
    }


}
