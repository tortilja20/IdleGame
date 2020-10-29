using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int ID;
    public string Name;
    public string Desc;
    public Sprite Icon;
    public bool isArtifact;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int ID, string Name, string Desc, Sprite Icon, Dictionary<string,int> stats)
    {
        this.ID = ID;
        this.Name = Name;
        this.Desc = Desc;
        this.Icon = Icon;
        this.stats = stats;
    }
}
