using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossMenu : MonoBehaviour
{
    public void MainGameScene()
    {
        SceneManager.LoadScene("Maingame");
    }
    public void EndcreditScene()
    {
        SceneManager.LoadScene("Endcredit");
    }
}
