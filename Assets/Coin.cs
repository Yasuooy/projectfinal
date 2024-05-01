using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.name == "Player")
        {
            SCORE.myscore += 1;
            Destroy(gameObject);
        }
    }
}
