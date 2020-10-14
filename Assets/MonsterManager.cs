using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System;
public class MonsterManager : MonoBehaviour
{

    public static int counter = 0;
    public static double MonsterHP = 10;
    public static double LootValue = 5;
    public static int ImgIndex = 1;
    public static int Stage = 1;

    public static GameObject monster = null;
    public GameObject emptyMonster;
    public Text HpText;
    public Text StageText;
    public Text counterText;
    public Text PrestigueText;
    public static double PresPoints;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = "Mob " + counter;
        StageText.text = "Stage " + Stage;
        if (monster == null)
        {
            monster = Instantiate(emptyMonster,new Vector3(0,0,0),new Quaternion() );
            var MonStats = monster.GetComponent<Monster>();
            counter++;
            if (counter==10)
            {
                MonStats.ImageIndex = ImgIndex;

                MonStats.MonsterHP = MonsterHP*10;
                MonStats.LootValue = LootValue*5;
                MonStats.isBoss = true;

                counter = 0;
            }
            else
            {
                //insert function to randomly show different monster sprites
                //currently unused
                MonStats.ImageIndex = ImgIndex;

                MonStats.MonsterHP = MonsterHP;
                MonStats.LootValue = LootValue;
                MonStats.isBoss = false;      
            }
            MonStats.HpText = HpText;
        }

        PresPoints = Math.Round((150 * Math.Sqrt(Money.gold / 1e7)*1));
        PrestigueText.text = "Prestigue on reset = " + PresPoints;
    }

   public static void StageClear()
    {
        MonsterHP += Math.Round(MonsterHP * (0.3 * Stage));
        LootValue += Math.Round(LootValue * (0.3 * Stage));
        Stage++;
    }


}
