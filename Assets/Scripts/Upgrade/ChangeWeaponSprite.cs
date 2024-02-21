using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeWeaponSprite : MonoBehaviour
{
    private Sprite[] sprites;
    private Image weaponImg;

    private void Awake()
    {
        weaponImg = gameObject.GetComponent<Image>();
        sprites = Resources.LoadAll<Sprite>("Weapon/Icons");
    }
    public void ChangeWeaponSprites(int val)
    {
        weaponImg.sprite = sprites[val];
    }
}
