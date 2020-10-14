using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text XpText;
    public Text PlyerLvlText;


    // Update is called once per frame
    void Update()
    {
        XpText.text = LevelingScript.XP + " XP";
        PlyerLvlText.text = LevelingScript.Level + "LVL";
    }
}
