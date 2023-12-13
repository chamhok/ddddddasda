using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultStatesData", menuName = "TopDownCountroller/States/Default", order = 0)]

public class StatesSO : ScriptableObject
{
    [Header("States Info")]
    [Range(1, 100)] public int Strength;
    [Range(1, 100)] public int Health;
    [Range(1, 100)] public int Agility;
    [Range(1, 100)] public int Intellect;
    [Range(1, 100)] public int Luck;
    [Range(1, 50000)] public int Gold;
}
