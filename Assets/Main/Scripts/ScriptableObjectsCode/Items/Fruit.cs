using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Fruit", menuName = "CustomObject/Item/Fruit")]
public class Fruit : Item
{
    readonly public ItemType itemType = ItemType.Fruit;
}
