using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextTMPviewer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textGold;
    [SerializeField] private TextMeshProUGUI textWeapon;
    [SerializeField] private TextMeshProUGUI textPercent;
    [SerializeField] private TextMeshProUGUI textNeedGold;
    [SerializeField] private TextMeshProUGUI textSellGold;
    [SerializeField] private TextMeshProUGUI textWeaponName;
    [SerializeField] private PlayerGold playerGold;
    [SerializeField] private WeaponUpgrade weaponUpgrade;

    public void Update()
    {
        textWeapon.text = "+" + weaponUpgrade.weaponValue.ToString();
        textPercent.text = weaponUpgrade.weaponSuccessPercent.ToString()+"%";
        textGold.text = playerGold.HaveGold.ToString();
        textNeedGold.text = weaponUpgrade.needGold.ToString();
        textSellGold.text = weaponUpgrade.sellGold.ToString();
        textWeaponName.text = weaponUpgrade.weaponNaming;
    }
}
