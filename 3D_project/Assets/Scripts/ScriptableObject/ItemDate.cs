using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable,
    Resource
}

public enum ConsumbleType
{
    HP
}

[Serializable]
public class ItemDateConsumble
{
    public ConsumbleType Type;
    public float value;
}

[CreateAssetMenu (fileName = "Item", menuName = "New Item")]
public class ItemDate : ScriptableObject
{
    [Header("Info")]
    public string disPlayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Consumble")]
    public ItemDateConsumble[] consumbles;
}
