using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IsUpgrade : MonoBehaviour
{
    private TextMeshProUGUI textUpgrade;
    private TMPAlpha tmpAlpha;

    private void Awake()
    {
        textUpgrade = GetComponent<TextMeshProUGUI>();
        tmpAlpha = GetComponent<TMPAlpha>();
    }
    
    public void PrintTextUpgrade(bool success)
    {
        if(success)
        {
            textUpgrade.text = "성공!";
            textUpgrade.color = new Color32(92, 255, 83, 0);
        }
        else
        {
            textUpgrade.text = "실패...";
            textUpgrade.color = new Color32(255, 40, 40, 0);

        }
        tmpAlpha.FadeOut();
    }

    public void PrintTextGold()
    {
        textUpgrade.text = "금액 부족";
        textUpgrade.color = new Color32(255, 40, 40, 0);
        tmpAlpha.FadeOut();
    }
}
