using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void MoveMain()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void MoveUpgrade()
    {
        SceneManager.LoadScene("UpgradeScene");
    }

}