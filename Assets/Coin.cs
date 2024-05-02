using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            SCORE.myscore += 1;
            Destroy(gameObject);
        }
    }
}
