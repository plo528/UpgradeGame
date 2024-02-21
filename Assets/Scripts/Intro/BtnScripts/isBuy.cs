using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isBuy : MonoBehaviour
{
    [SerializeField] private WeaponUpgrade weaponUpgrade;
    [SerializeField] private GameObject pop;
    [SerializeField] private IsUpgrade isUpgrade;
    public void OnClickIsBuy()
    {
        if (weaponUpgrade.weaponValue >= 1)
        {
            isUpgrade.PrintTextShop();
        }
        else
        {
            pop.SetActive(true);
        }
    }
}
