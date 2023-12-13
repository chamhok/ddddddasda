using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstlButton : MonoBehaviour
{
    private StatesSO _playerStates;

    private void Start()
    {
        _playerStates = GameManager.I.Player.GetComponent<CharacterStatsHandeler>().CurrentStats.StatesSO;
    }

    public void Instl()
    {
        
        _playerStates.Strength += GameManager.I.CurrentItme.Strength;
        _playerStates.Health += GameManager.I.CurrentItme.Health;
        _playerStates.Agility += GameManager.I.CurrentItme.Agility;
        _playerStates.Intellect += GameManager.I.CurrentItme.Intellect;
        _playerStates.Luck += GameManager.I.CurrentItme.Luck;
        GameManager.I.ItemDictionary[GameManager.I.CurrentItme.Name].IsInstl = true;
    }

    public void UnInstl()
    {
        
        _playerStates.Strength -= GameManager.I.CurrentItme.Strength;
        _playerStates.Health -= GameManager.I.CurrentItme.Health;
        _playerStates.Agility -= GameManager.I.CurrentItme.Agility;
        _playerStates.Intellect -= GameManager.I.CurrentItme.Intellect;
        _playerStates.Luck -= GameManager.I.CurrentItme.Luck;
        GameManager.I.ItemDictionary[GameManager.I.CurrentItme.Name].IsInstl = false;
    }

}
