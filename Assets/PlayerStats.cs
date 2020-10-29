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
    public static double Wheat;
    public static double Meat;
    public static double Beet;

    public static double CollableWheat;
    public static double CollableMeat;
    public static double CollableBeet;

    public static double Wheatph=0;
    public static double Meatph=0;
    public static double Beetph=0;

    public static void BuyFarm(string type)
    {
        switch(type)
        {
            case "Wheat":
                Wheatph += 10;
                break;
            case "Meat":
                Meatph += 10;
                break;
            case "Beet":
                Beetph += 10;
                break;

        }
        Money.gems -= 100;

    }




}


public static class Dmg{

    public static double Calc()
    {
     //   foreach (var item in Inventory.storeditems)


        double TotalDamage = 0;

        return PlayerStats.Damage * ((Money.prestigue * 0.01) + 1);
    }
}


