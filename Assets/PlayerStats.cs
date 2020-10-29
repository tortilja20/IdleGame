using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class PlayerStats
{
    public static double Damage = 1;
    public static string ClassName;
    public static string ClassDesc;
    public static List<Skill> PlayerSkills;
}


public static class PetStats
{
    public static double DamageOT = 0;
}

public static class Resources
{
    public static double water;
    public static double fire;
    public static double stone;
}

public static class Dmg{

    public static double Calc()
    {
     //   foreach (var item in Inventory.storeditems)


        double TotalDamage = 0;

        return PlayerStats.Damage * ((Money.prestigue * 0.01) + 1);
    }
}


