using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Reset()
    {
        System.Console.WriteLine("Reset");
        ResetScript.Reset();
    }

}
