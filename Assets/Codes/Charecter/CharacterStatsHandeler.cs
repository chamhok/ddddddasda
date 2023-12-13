using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandeler : MonoBehaviour
{
    [SerializeField] private CharacterStats baseStats;
    public CharacterStats CurrentStats { get; private set; }
    public List<CharacterStats> StatsModifiers = new List<CharacterStats>();

    private void Awake()
    {
        UpdataCharecterStats();
    }

    private void UpdataCharecterStats()
    {
        StatesSO statesSO = null;
        if (baseStats.StatesSO != null)
        {
            statesSO = Instantiate(baseStats.StatesSO);
        }

        CurrentStats = new CharacterStats { StatesSO = statesSO };
        //TODO

        CurrentStats.StatsChangeType = baseStats.StatsChangeType;
        CurrentStats.CurrentExp = baseStats.CurrentExp;
    }

}
