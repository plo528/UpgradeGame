using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void MoveIntro()
    {
        SceneManager.LoadScene("IntroScene");
    }
    public void MoveUpgrade()
    {
        SceneManager.LoadScene("UpgradeScene");
    }

}