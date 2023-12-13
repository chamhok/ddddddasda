using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public GameObject Player;

    public Button InstlButton;
    public Button UnInstlButton;

    public TextMeshProUGUI CurrentGold;

    public ItmeStates CurrentItme;

    public Dictionary<string, ItmeStates> ItemDictionary = new Dictionary<string, ItmeStates>();

    public CharacterStats _characterStats;

    private void Awake()
    {
        I = this;
    }
    private void Start()
    {
        _characterStats = Player.GetComponent<CharacterStatsHandeler>().CurrentStats;
        CurrentGold.text = Player.GetComponent<CharacterStatsHandeler>().CurrentStats.StatesSO.Gold.ToString();
        foreach (var value in GameManager.I.ItemDictionary.Values)
        {
            if (!value.IsInstl) return;
            _characterStats.StatesSO.Strength += value.Strength;
            _characterStats.StatesSO.Health += value.Health;
            _characterStats.StatesSO.Agility += value.Agility;
            _characterStats.StatesSO.Intellect += value.Intellect;
            _characterStats.StatesSO.Luck += value.Luck;
        }
    }
}
