using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingScript
{

    public static double XP = 0;
    public static double XPToNextLevel = 100;
    public static double Level = 1;

    public static void LevelUp()
    {
        Level++;
        XPToNextLevel *= 2.3; 
    }
}



