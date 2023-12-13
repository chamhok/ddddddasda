using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItmeStates : MonoBehaviour
{
    public string Name;
    public string Explanation;

    public bool IsInstl;
    public bool IsBuy;

     public int Gold;
    [Range(1, 100)] public int Strength;
    [Range(1, 100)] public int Health;
    [Range(1, 100)] public int Agility;
    [Range(1, 100)] public int Intellect;
    [Range(1, 100)] public int Luck;

    public ItemSO itemSO;
}
