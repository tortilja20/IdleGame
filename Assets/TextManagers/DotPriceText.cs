using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class DotPriceText : MonoBehaviour
{
    private Text DotText;

    void Start()
    {
        DotText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        DotText.text = "Dot price" + Upgrade.DoTPrice* Upgrade.DoTMulti;
    }
}
