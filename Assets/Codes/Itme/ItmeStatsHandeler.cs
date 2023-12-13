using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItmeStatsHandeler : MonoBehaviour
{
    [SerializeField] private ItmeStates baseStats;
    public ItmeStates CurrentStats { get; private set; }
    public List<ItmeStates> StatsModifiers = new List<ItmeStates>();

    private void Awake()
    {
        UpdataItemStats();
    }

    private void UpdataItemStats()
    {
        ItemSO itemSO = null;
        if (baseStats.itemSO != null)
        {
            itemSO = Instantiate(baseStats.itemSO);
        }

        CurrentStats = new ItmeStates { itemSO = itemSO };
        //TODO
        CurrentStats.Strength = baseStats.Strength;
        CurrentStats.Health = baseStats.Health;
        CurrentStats.Agility = baseStats.Agility;
        CurrentStats.Intellect = baseStats.Intellect;
        CurrentStats.Luck = baseStats.Luck;


        CurrentStats.Name = baseStats.Name;
        CurrentStats.Explanation = baseStats.Explanation;
        CurrentStats.Gold = baseStats.Gold;
    }
}
