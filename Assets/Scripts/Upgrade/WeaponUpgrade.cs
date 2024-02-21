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
    public int notBroken = 0;
    public string weaponNaming;
    public string upgradeBtn;
    public string sellBtn;
    private int percentDownCheck = 0;
    private bool firstUpgrade = true;
    private bool success = false;
    private bool broken = false;

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

    private void Update()
    {
        if (broken)
        {
            upgradeBtn = "취소";
            sellBtn = "복구";
        }
        else
        {
            upgradeBtn = "강화";
            sellBtn = "판매";
        }
    }
    public void DoUpgrade()
    {
        if (needGold > playerGold.HaveGold)
        {
            isUpgrade.PrintTextGold();
        }
        else if(broken == true)
        {
            ResetWeapon();
        }
        else
        {
            DoWeaponUpgrade();
        }
    }
    public void DoSell()
    {
        if(broken == true)
        {
            HaveNotBroken();
        }
        else
        {
            SellingWeapon();
        }
        
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

            //판매금액
            if (firstUpgrade)
            {
                sellGold = 150;
                firstUpgrade = false;
            }
            else
            {
                if(weaponValue < 10)
                {
                    sellGold = sellGold * 2;
                }
                else
                {
                    sellGold = sellGold * 3;
                }
            }

            changeWeaponSprite.ChangeWeaponSprites(weaponValue);
            weaponNaming = weaponName.ChangeName(weaponValue);

        }
        else
        {
            success = false;
            broken = true;
        }
        isUpgrade.PrintTextUpgrade(success);
    }

    private void SellingWeapon()
    {
        playerGold.HaveGold += sellGold;
        ResetWeapon();
    }
    private void HaveNotBroken()
    {
        if(notBroken >= 1)
        {
            notBroken--;
            broken = false;
        }
        else
        {
            isUpgrade.PrintTextBroken();
        }
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
        broken = false;
    }
    public void BuyNoBroken()
    {
        playerGold.HaveGold -= 1000000;
        notBroken++;
    }
    public void JumpUpgrade9()
    {
        if(playerGold.HaveGold < 1000000)
        {
            return;
        }
        playerGold.HaveGold -= 1000000;
        for(int i = 0; i<10; i++)
        {
            weaponValue++;
            percentDownCheck++;
            if (percentDownCheck == 2)
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
                if (weaponValue < 10)
                {
                    sellGold = sellGold * 2;
                }
                else
                {
                    sellGold = sellGold * 3;
                }
            }

        }

        changeWeaponSprite.ChangeWeaponSprites(weaponValue);
        weaponNaming = weaponName.ChangeName(weaponValue);
    }
    public void JumpUpgrade13()
    {
        if (playerGold.HaveGold < 7000000)
        {
            return;
        }
        playerGold.HaveGold -= 7000000;
        for (int i = 0; i < 14; i++)
        {
            weaponValue++;
            percentDownCheck++;
            if (percentDownCheck == 2)
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
                if (weaponValue < 10)
                {
                    sellGold = sellGold * 2;
                }
                else
                {
                    sellGold = sellGold * 3;
                }
            }

        }

        changeWeaponSprite.ChangeWeaponSprites(weaponValue);
        weaponNaming = weaponName.ChangeName(weaponValue);
    }
    public void JumpUpgrade14()
    {
        if (playerGold.HaveGold < 10000000)
        {
            return;
        }
        playerGold.HaveGold -= 10000000;
        for (int i = 0; i < 15; i++)
        {
            weaponValue++;
            percentDownCheck++;
            if (percentDownCheck == 2)
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
                if (weaponValue < 10)
                {
                    sellGold = sellGold * 2;
                }
                else
                {
                    sellGold = sellGold * 3;
                }
            }

        }

        changeWeaponSprite.ChangeWeaponSprites(weaponValue);
        weaponNaming = weaponName.ChangeName(weaponValue);
    }
    public void JumpUpgrade15()
    {
        if (playerGold.HaveGold < 15000000)
        {
            return;
        }
        playerGold.HaveGold -= 15000000;
        for (int i = 0; i < 14; i++)
        {
            weaponValue++;
            percentDownCheck++;
            if (percentDownCheck == 2)
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
                if (weaponValue < 10)
                {
                    sellGold = sellGold * 2;
                }
                else
                {
                    sellGold = sellGold * 3;
                }
            }

        }

        changeWeaponSprite.ChangeWeaponSprites(weaponValue);
        weaponNaming = weaponName.ChangeName(weaponValue);
    }
}

