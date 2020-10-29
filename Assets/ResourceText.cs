using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ResourceText : MonoBehaviour
{
    public Text resText;
    public CollectScript collect;


    // Update is called once per frame
    void Update()
    {
        resText.text = Math.Round(collect.CollectableWheat) +"Wheat to collect";
    }
}
