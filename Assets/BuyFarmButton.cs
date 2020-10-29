using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyFarmButton : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void BuyFarm()
    {

        if (Money.gems >= 100)
        {
            Resources.BuyFarm("Wheat");
            CollectionTimer.LastCollect = System.DateTime.UtcNow;
        }
        

    }
}
