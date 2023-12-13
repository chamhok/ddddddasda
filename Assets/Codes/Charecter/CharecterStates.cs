using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
    Add,
    Multiple,
    Override
}
[Serializable]
public class CharacterStats
{
    public StatsChangeType StatsChangeType;

    public float CurrentExp;
    public StatesSO StatesSO;
}
