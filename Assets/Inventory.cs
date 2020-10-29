using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Inventory
{
    public static List<Item> storeditems;

    public static void  GiveItem(int id)
    {
        storeditems.Add(ItemDatabase.GetItem(id));
    }

    public static void GiveItem(string name)
    {
        storeditems.Add(ItemDatabase.GetItem(name));
    }



    public static Item GetItem(int id)
    {
        return storeditems.Find(item => item.ID == id);
    }

    public static Item GetItem(string ItemName)
    {
        return storeditems.Find(item => item.Name == ItemName);
    }

}
