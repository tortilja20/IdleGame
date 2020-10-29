using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResetScript
{
    public static void  Reset()
    {
        MonsterManager.counter = 0;
        MonsterManager.MonsterHP = 10;
        MonsterManager.LootValue = 5;
        MonsterManager.ImgIndex = 1;
        MonsterManager.Stage = 1;
        GameObject.Destroy(MonsterManager.monster);

        PlayerStats.Damage = 1;

        PetStats.DamageOT = 0;

        Upgrade.DoTMulti = 1;
        Upgrade.DMGMulti = 1;
        Upgrade.DoTPrice = 50;
        Upgrade.DMGPrice = 10;

        LevelingScript.XP = 0;
        LevelingScript.XPToNextLevel = 100;
        LevelingScript.Level = 1;

        Money.gold = 0;
        Money.prestigue += MonsterManager.PresPoints;

    }

}
