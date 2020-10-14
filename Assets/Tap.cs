using System.Collections;
using System.Runtime;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System;

public class Tap : MonoBehaviour
{
    // Start is called before the first frame update

    public double MonsterHP;
    public Text ClickText;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
            ClickText.text = "HP = " + Math.Round(MonsterHP);
    }

}
