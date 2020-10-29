using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemDatabase
{
    public static List<Item> Items;

    public static void CreateItemList()
    {
        Items = new List<Item>()
        {
            new Item(0,"Sword","Does Melee Damage",null,
            new Dictionary<string, int>
            {
                {"Price", 10 },
                {"Damage", 10 },
            }),
            new Item(1,"Bow","Does Ranged Damage",null,
            new Dictionary<string, int>
            {
                {"Price", 10 },
                {"Damage", 10 },
            }),
            new Item(2,"Dagger","Does Melle & Poison Damage",null,
            new Dictionary<string, int>
            {
                {"Price", 20 },
                {"Damage", 5 },
            }),
            new Item(3,"Shield","Blocks Damage",null,
            new Dictionary<string, int>
            {
                {"Price", 20 },
                {"Defense", 5 },
            }),
            new Item(4,"Breast Plate","Blocks Damage",null,
            new Dictionary<string, int>
            {
                {"Price", 20 },
                {"Defense", 15 },
            }),
        };
    }

    public static Item GetItem(int id)
    {
        return Items.Find(item => item.ID == id);
    }

    public static Item GetItem(string ItemName)
    {
        return Items.Find(item => item.Name == ItemName);
    }
}
