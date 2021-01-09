using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Vegetable", menuName = "CustomObject/Item/Vegetable")]
public class Vegetable : Item
{
    readonly public ItemType itemType = ItemType.Vegetable;
}
