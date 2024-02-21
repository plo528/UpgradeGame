using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WeaponUpgrade : MonoBehaviour
{
    [SerializeField] private IsUpgrade isUpgrade;
    [SerializeField] private PlayerGold playerGold;
    [SerializeField] private ChangeWeaponSprite changeWeaponSprite;
    [SerializeField] private WeaponName weaponName;
    public int sellGold = 0;
    public int needGold = 300;
    public int weaponValue = 0;
    public int weaponSuccessPercent = 100;
    public string weaponNaming;
    private int percentDownCheck = 0;
    private bool firstUpgrade = true;
    private bool success = false;

    private void Awake()
    {
        weaponNaming = weaponName.ChangeName(0);
        sellGold = 0;
        needGold = 300;
        weaponSuccessPercent = 100;
        percentDownCheck = 0;
        firstUpgrade = true;
        success = false;
    }
    public void DoUpgrade()
    {
        if (needGold > playerGold.HaveGold)
        {
            isUpgrade.PrintTextGold();
        }
        else
        {
            DoWeaponUpgrade();
        }
    }
    public void DoSell()
    {
        SellingWeapon();
    }
    
    private void DoWeaponUpgrade()
    {
        if(weaponValue >= 40)
        {
            return;
        }
        playerGold.HaveGold -= needGold;
        int percent = Random.Range(0, 100);
        if(weaponSuccessPercent >= percent)
        {
            success = true;
            weaponValue++;
            percentDownCheck++;

            if(percentDownCheck == 2)
            {
                weaponSuccessPercent -= 5;
                percentDownCheck = 0;
                needGold = needGold + (needGold / 2);
            }

            if (firstUpgrade)
            {
                sellGold = 150;
                firstUpgrade = false;
            }
            else
            {
                sellGold = sellGold * 2 - (sellGold / 10 * 2);
            }

            changeWeaponSprite.ChangeWeaponSprites(weaponValue);
            weaponNaming = weaponName.ChangeName(weaponValue);

        }
        else
        {
            success = false;
            ResetWeapon();
        }
        isUpgrade.PrintTextUpgrade(success);
    }

    private void SellingWeapon()
    {
        playerGold.HaveGold += sellGold;
        ResetWeapon();
    }

    private void ResetWeapon()
    {
        weaponValue = 0;
        needGold = 300;
        sellGold = 0;
        percentDownCheck = 0;
        firstUpgrade = true;
        weaponSuccessPercent = 100;
        changeWeaponSprite.ChangeWeaponSprites(0);
        weaponNaming = weaponName.ChangeName(0);
    }
}
