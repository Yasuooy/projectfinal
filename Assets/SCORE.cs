using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORE : MonoBehaviour
{
    static public int myscore;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score :  " + myscore;
    }
}
