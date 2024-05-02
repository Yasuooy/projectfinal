using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            Destroy(Other.gameObject);
            SceneManager.LoadScene("Die");
        }
    }
}
