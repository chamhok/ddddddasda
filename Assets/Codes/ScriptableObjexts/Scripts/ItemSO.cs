using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultItmeData", menuName = "TopDownCountroller/Item/Default", order = 1)]
public class ItemSO : ScriptableObject
{
    [Header("Prefeb")]
    public GameObject Prefeb;
}
