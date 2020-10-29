using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.PlayerLoop;
using System.Xml.XPath;
using UnityEditor.Experimental.GraphView;

public class Monster : MonoBehaviour
{

    public double MonsterHP;
    public double LootValue;
    public int ImageIndex;
    private System.Random rand;
    public bool isBoss;
    public Text HpText;
    private float GemChance = 0.5f;
    private double GemValue;
    private double xpValue;

    void Start()
    {
        InvokeRepeating("MonsterDOT", 0f, 1.0f);
        GemValue = 1;
        xpValue = Math.Round(MonsterHP * 0.1);
        rand = new System.Random();
    }

    void Update()
    {
        if (MonsterHP <= 0)
        {
            MonterKill();
        }

        //used for testing with mouse on pc

        if (Input.GetMouseButtonDown(0) || Input.mouseScrollDelta.y > 0)
        {
            MonsterDMG();
            Debug.Log("mouse was pressed");
        }

        foreach (Touch touch in Input.touches)
        {
            if (Input.GetTouch(touch.fingerId).phase == TouchPhase.Ended)
            {
                MonsterDMG();
                Debug.Log(touch.fingerId + " was pressed");
            }
        }
        HpText.text = "HP = " + Math.Round(MonsterHP);
    }

    public void MonterKill()
    {
        Money.gold += Math.Round(LootValue - (rand.NextDouble() * (LootValue / 25)));
        LevelingScript.XP += xpValue;
        if (LevelingScript.XP >= LevelingScript.XPToNextLevel)
            LevelingScript.LevelUp();


        System.Random rnd = new System.Random();
        int roll = rnd.Next(1, 3);
        switch (roll)
        {
            case 1:
                Resources.Wheat += 1;
                break;
            case 2:
                Resources.Meat += 1;
                break;
            case 3:
                Resources.Beet += 1;
                break;
            default:
                break;
        }



        if (UnityEngine.Random.Range(0f,1f) < GemChance)
        {
            Money.gems += GemValue;
        }

        // spot for animations baby 
        if (isBoss)
        {
            BossKill();
        }

        Destroy(gameObject);
    }

    void MonsterDOT()
    {
        MonsterHP -= PetStats.DamageOT;
    }

    void MonsterDMG()
    {
        MonsterHP -= Dmg.Calc();
    }

    void BossKill()
    {
        //change of event or something
        MonsterManager.StageClear();
    }

}
