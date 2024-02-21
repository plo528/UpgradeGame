using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGold : MonoBehaviour
{
    [SerializeField] private int haveGold = 1000000;

    public int HaveGold { get { return haveGold; } set { haveGold = value; } }
    public void Awake()
    {
        haveGold = 1000000;
    }
}
